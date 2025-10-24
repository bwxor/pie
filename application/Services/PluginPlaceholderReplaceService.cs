/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace pie.Services
{
    public class PluginPlaceholderReplaceService
    {
        public string ReplaceInputControlPlaceholders(string input, Dictionary<string, string> inputControls)
        {
            string result;
            result = Regex.Replace(
                input,
                @"\$\{controls\.(?<key>[^}]+)\}",
                match =>
                {
                    string key = match.Groups["key"].Value;

                    if (inputControls.TryGetValue(key, out string replacementValue))
                    {
                        return replacementValue;
                    }
                    else
                    {
                        return match.Value;
                    }
                }
            );

            return result;
        }
    }
}
