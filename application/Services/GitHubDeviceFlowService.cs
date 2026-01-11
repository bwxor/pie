using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace pie.Services
{
    public record DeviceCodeResponse(
        [property: JsonPropertyName("device_code")] string DeviceCode,
        [property: JsonPropertyName("user_code")] string UserCode,
        [property: JsonPropertyName("verification_uri")] string VerificationUri,
        [property: JsonPropertyName("interval")] int Interval
    );

    public record TokenResponse(
        [property: JsonPropertyName("access_token")] string AccessToken,
        [property: JsonPropertyName("error")] string Error,
        [property: JsonPropertyName("error_description")] string ErrorDescription
    );

    public class GitHubDeviceFlowService
    {
        private const string ClientId = "Ov23liozrabV4rR1SUxz";
        private static readonly HttpClient Http = new HttpClient();

        public GitHubDeviceFlowService()
        {
            if (Http.DefaultRequestHeaders.UserAgent.Count == 0)
                Http.DefaultRequestHeaders.UserAgent.ParseAdd("Pie-Git-App");

            Http.DefaultRequestHeaders.Accept.Clear();
            Http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<DeviceCodeResponse> StartDeviceFlowAsync()
        {
            var requestParams = new Dictionary<string, string> { { "client_id", ClientId }, { "scope", "repo" } };
            var response = await Http.PostAsync("https://github.com/login/device/code", new FormUrlEncodedContent(requestParams));
            return await response.Content.ReadFromJsonAsync<DeviceCodeResponse>();
        }

        public async Task<string> PollForTokenAsync(string deviceCode, int interval, CancellationToken ct)
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromSeconds(interval + 1), ct);

                var pollParams = new Dictionary<string, string> {
            { "client_id", ClientId },
            { "device_code", deviceCode },
            { "grant_type", "urn:ietf:params:oauth:grant-type:device_code" }
        };

                var response = await Http.PostAsync("https://github.com/login/oauth/access_token", new FormUrlEncodedContent(pollParams), ct);
                var tokenData = await response.Content.ReadFromJsonAsync<TokenResponse>(cancellationToken: ct);

                if (!string.IsNullOrEmpty(tokenData.AccessToken)) return tokenData.AccessToken;
                if (tokenData.Error == "authorization_pending") continue;
                if (tokenData.Error == "slow_down") { interval += 5; continue; }

                throw new Exception(tokenData.ErrorDescription ?? tokenData.Error);
            }
        }

        public async Task<string> GetGitHubUsername(string token, CancellationToken ct)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/user");
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await Http.SendAsync(request, ct);

            if (response.IsSuccessStatusCode)
            {
                using var doc = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync(ct), cancellationToken: ct);
                return doc.RootElement.GetProperty("login").GetString();
            }

            throw new Exception("Could not retrieve username. The token might be invalid or expired.");
        }
    }
}