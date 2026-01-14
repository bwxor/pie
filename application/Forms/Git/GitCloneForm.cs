/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

/** 
 * Krypton Suite's Standard Toolkit was often used in order to design the .NET controls found inside this application.
 * 
 * Copyright (c) 2017 - 2022, Krypton Suite
*/
using Krypton.Toolkit;
/**
 * LibGit2Sharp is used for integrating several advanced Git functionalities into pie.
 * 
 * Copyright (c) LibGit2Sharp contributors
 */
using LibGit2Sharp;
using pie.Classes;
using pie.Constants;
using pie.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pie
{
    public partial class GitCloneForm : KryptonForm
    {
        private ThemingService themeService = new ThemingService();

        public GitCloneFormInput Input { get; set; }
        public GitCloneFormOutput Output { get; set; }

        public GitCloneForm()
        {
            InitializeComponent();
            DoubleBuffered = true;

            Output = new GitCloneFormOutput();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void GitCloneForm_Load(object sender, EventArgs e)
        {
            themeService.SetPaletteToObjects(this, Input.Palette);

            if (Input.EditorProperties.Glass)
            {
                this.Opacity = 0.875;
            }

            Output.ClonePath = null;
        }

        public void ShowNotification(string text)
        {
            NotificationOKForm notificationOkForm = new NotificationOKForm();

            NotificationFormInput notificationFormInput = new NotificationFormInput();
            notificationFormInput.EditorProperties = new EditorProperties();
            notificationFormInput.Palette = Input.Palette;
            notificationFormInput.NotificationText = text;

            notificationOkForm.Input = notificationFormInput;

            notificationOkForm.ShowDialog();
        }

        private void Clone()
        {
            if (repositoryURLTextBox.Text == "" || cloneIntoTextBox.Text == "")
            {
                ShowNotification("Repository URL and clone location should not be empty.");
            }
            else if (!Directory.Exists(cloneIntoTextBox.Text))
            {
                ShowNotification("Directory does not exist. Create it before cloning a repository.");
            }
            else if (Directory.GetFiles(cloneIntoTextBox.Text).Length > 0 || Directory.GetDirectories(cloneIntoTextBox.Text).Length > 0)
            {
                ShowNotification("Specified directory needs to be empty.");
            }
            else
            {
                GitClone();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Clone();
        }

        private async void GitClone()
        {
            if (Input.GitCredentials.Username == null || Input.GitCredentials.Password == null)
            {
                Input._authCancellationSource = new CancellationTokenSource();

                var auth = new GitHubDeviceFlowService();

                try
                {
                    var deviceData = await auth.StartDeviceFlowAsync();

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(deviceData.VerificationUri)
                    {
                        UseShellExecute = true
                    });

                    ShowNotification($"1. A browser has opened to GitHub.\n2. Enter this code: {deviceData.UserCode}\n\nClick OK once you have authorized the app.");

                    string token = await auth.PollForTokenAsync(deviceData.DeviceCode, deviceData.Interval, Input._authCancellationSource.Token);

                    string username = await auth.GetGitHubUsername(token, Input._authCancellationSource.Token);

                    Input.GitCredentials.Username = username;
                    Input.GitCredentials.Password = token;

                    new ConfigurationService().WriteToFile(
                        System.IO.Path.Combine(SpecialPaths.Config, "git.json"),
                        new List<GitCredentials>() { Input.GitCredentials }
                    );

                    GitClone();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Authentication failed: {ex.Message}");
                }
            }
            else
            {
                var options = new CloneOptions
                {
                    FetchOptions = {
                        CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials
                        {
                            Username = Input.GitCredentials.Username,
                            Password = Input.GitCredentials.Password
                        }
                    }
                };

                if (Input.GitCredentials.Proxy != null && Input.GitCredentials.Proxy.Length > 0)
                {
                    options.FetchOptions.ProxyOptions.Url = Input.GitCredentials.Proxy;
                    options.FetchOptions.ProxyOptions.ProxyType = ProxyType.Specified;
                }
                else
                {
                    options.FetchOptions.ProxyOptions.Url = null;
                    options.FetchOptions.ProxyOptions.ProxyType = ProxyType.None;
                }

                try
                {
                    Task.Run(() =>
                    {
                        Repository.Clone(repositoryURLTextBox.Text, cloneIntoTextBox.Text, options);
                    }).Wait();

                    Output.ClonePath = cloneIntoTextBox.Text;
                    this.Close();
                }
                catch (NameConflictException e)
                {
                    ShowNotification(e.Message);
                }
                catch (LibGit2SharpException e)
                {
                    ShowNotification(e.Message);
                }
                catch (Exception e)
                {
                    ShowNotification("Could not clone repository. Check if you have the right permissions and if the repository URL is correct.");
                }
            }
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                cloneIntoTextBox.Text = dialog.SelectedPath;
            }
        }

        private void GitCloneForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clone();
            }
        }

        private void repositoryURLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clone();
            }
        }

        private void cloneIntoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clone();
            }
        }
    }
}
