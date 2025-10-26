﻿/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

/** 
 * Krypton Suite's Standard Toolkit was often used in order to design the .NET controls found inside this application.
 * 
 * Copyright (c) 2017 - 2022, Krypton Suite
*/
using Krypton.Toolkit;
using pie.Classes;
using pie.Services;
using System;
using System.Windows.Forms;

namespace pie
{
    public partial class GitPushCredentialsForm : KryptonForm
    {
        private ThemingService themeService = new ThemingService();

        public GitPushCredentialsFormInput Input { get; set; }
        public GitPushCredentialsFormOutput Output { get; set; }

        public GitPushCredentialsForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Output = new GitPushCredentialsFormOutput();
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

        private void GitPushCredentialsForm_Load(object sender, EventArgs e)
        {
            themeService.SetPaletteToObjects(this, Input.Palette);

            if (Input.EditorProperties.Glass)
            {
                this.Opacity = 0.875;
            }

            if (Input.GitCredentials.Username != null)
            {
                remoteServerUsernameTextBox.Text = Input.GitCredentials.Username;
            }

            if (Input.GitCredentials.Password != null)
            {
                remoteServerPasswordTextBox.Text = Input.GitCredentials.Password;
            }
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

        private void ProceedWithCredentials()
        {
            if (remoteServerUsernameTextBox.Text != "" && remoteServerPasswordTextBox.Text != "")
            {
                Input.GitCredentials.Username = remoteServerUsernameTextBox.Text;
                Input.GitCredentials.Password = remoteServerPasswordTextBox.Text;

                Output.Saved = true;

                this.Close();
            }
            else
            {
                ShowNotification("Username and Password cannot be blank.");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ProceedWithCredentials();
        }

        private void GitPushCredentialsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProceedWithCredentials();
            }
        }

        private void remoteServerUsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProceedWithCredentials();
            }
        }

        private void remoteServerPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProceedWithCredentials();
            }
        }
    }
}
