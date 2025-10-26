namespace pie
{
    partial class GitPushCredentialsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitPushCredentialsForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            remoteServerPasswordLabel = new Krypton.Toolkit.KryptonLabel();
            remoteServerUsernameLabel = new Krypton.Toolkit.KryptonLabel();
            remoteServerPasswordTextBox = new Krypton.Toolkit.KryptonTextBox();
            remoteServerUsernameTextBox = new Krypton.Toolkit.KryptonTextBox();
            saveButton = new Krypton.Toolkit.KryptonButton();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(remoteServerPasswordLabel);
            mainPanel.Controls.Add(remoteServerUsernameLabel);
            mainPanel.Controls.Add(remoteServerPasswordTextBox);
            mainPanel.Controls.Add(remoteServerUsernameTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(568, 175);
            mainPanel.TabIndex = 3;
            // 
            // remoteServerPasswordLabel
            // 
            remoteServerPasswordLabel.Location = new System.Drawing.Point(10, 63);
            remoteServerPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            remoteServerPasswordLabel.Name = "remoteServerPasswordLabel";
            remoteServerPasswordLabel.Size = new System.Drawing.Size(230, 20);
            remoteServerPasswordLabel.TabIndex = 5;
            remoteServerPasswordLabel.Values.Text = "Remote Server Password / Access Token";
            // 
            // remoteServerUsernameLabel
            // 
            remoteServerUsernameLabel.Location = new System.Drawing.Point(10, 6);
            remoteServerUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            remoteServerUsernameLabel.Name = "remoteServerUsernameLabel";
            remoteServerUsernameLabel.Size = new System.Drawing.Size(149, 20);
            remoteServerUsernameLabel.TabIndex = 4;
            remoteServerUsernameLabel.Values.Text = "Remote Server Username";
            // 
            // remoteServerPasswordTextBox
            // 
            remoteServerPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            remoteServerPasswordTextBox.Location = new System.Drawing.Point(14, 87);
            remoteServerPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            remoteServerPasswordTextBox.Name = "remoteServerPasswordTextBox";
            remoteServerPasswordTextBox.PasswordChar = '●';
            remoteServerPasswordTextBox.Size = new System.Drawing.Size(541, 23);
            remoteServerPasswordTextBox.TabIndex = 3;
            remoteServerPasswordTextBox.KeyDown += remoteServerPasswordTextBox_KeyDown;
            // 
            // remoteServerUsernameTextBox
            // 
            remoteServerUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            remoteServerUsernameTextBox.Location = new System.Drawing.Point(14, 29);
            remoteServerUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            remoteServerUsernameTextBox.Name = "remoteServerUsernameTextBox";
            remoteServerUsernameTextBox.Size = new System.Drawing.Size(541, 23);
            remoteServerUsernameTextBox.TabIndex = 2;
            remoteServerUsernameTextBox.KeyDown += remoteServerUsernameTextBox_KeyDown;
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(466, 11);
            saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(89, 29);
            saveButton.TabIndex = 1;
            saveButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            saveButton.Values.Text = "Save";
            saveButton.Click += kryptonButton1_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(saveButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 128);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(568, 47);
            ButtonPanel.TabIndex = 4;
            // 
            // GitPushCredentialsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(568, 175);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "GitPushCredentialsForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Push Credentials";
            Load += GitPushCredentialsForm_Load;
            KeyDown += GitPushCredentialsForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonLabel remoteServerPasswordLabel;
        private Krypton.Toolkit.KryptonLabel remoteServerUsernameLabel;
        private Krypton.Toolkit.KryptonTextBox remoteServerPasswordTextBox;
        private Krypton.Toolkit.KryptonTextBox remoteServerUsernameTextBox;
        private Krypton.Toolkit.KryptonButton saveButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}