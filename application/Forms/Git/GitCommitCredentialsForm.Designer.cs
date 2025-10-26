namespace pie
{
    partial class GitCommitCredentialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitCommitCredentialsForm));
            saveButton = new Krypton.Toolkit.KryptonButton();
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            authorEmailLabel = new Krypton.Toolkit.KryptonLabel();
            authorNameLabel = new Krypton.Toolkit.KryptonLabel();
            authorEmailTextBox = new Krypton.Toolkit.KryptonTextBox();
            authorNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(367, 14);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(76, 25);
            saveButton.TabIndex = 1;
            saveButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            saveButton.Values.Text = "Save";
            saveButton.Click += kryptonButton1_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(authorEmailLabel);
            mainPanel.Controls.Add(authorNameLabel);
            mainPanel.Controls.Add(authorEmailTextBox);
            mainPanel.Controls.Add(authorNameTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(455, 172);
            mainPanel.TabIndex = 2;
            // 
            // authorEmailLabel
            // 
            authorEmailLabel.Location = new System.Drawing.Point(9, 55);
            authorEmailLabel.Name = "authorEmailLabel";
            authorEmailLabel.Size = new System.Drawing.Size(81, 20);
            authorEmailLabel.TabIndex = 5;
            authorEmailLabel.Values.Text = "Author Email";
            // 
            // authorNameLabel
            // 
            authorNameLabel.Location = new System.Drawing.Point(9, 5);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new System.Drawing.Size(84, 20);
            authorNameLabel.TabIndex = 4;
            authorNameLabel.Values.Text = "Author Name";
            // 
            // authorEmailTextBox
            // 
            authorEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            authorEmailTextBox.Location = new System.Drawing.Point(12, 75);
            authorEmailTextBox.Name = "authorEmailTextBox";
            authorEmailTextBox.Size = new System.Drawing.Size(424, 23);
            authorEmailTextBox.TabIndex = 3;
            authorEmailTextBox.KeyDown += authorEmailTextBox_KeyDown;
            // 
            // authorNameTextBox
            // 
            authorNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            authorNameTextBox.Location = new System.Drawing.Point(12, 25);
            authorNameTextBox.Name = "authorNameTextBox";
            authorNameTextBox.Size = new System.Drawing.Size(424, 23);
            authorNameTextBox.TabIndex = 2;
            authorNameTextBox.KeyDown += authorNameTextBox_KeyDown;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(saveButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 123);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(455, 49);
            ButtonPanel.TabIndex = 3;
            // 
            // GitCommitCredentialsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(455, 172);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GitCommitCredentialsForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Commit Credentials";
            Load += GitCommitCredentialsForm_Load;
            KeyDown += GitCommitCredentialsForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton saveButton;
        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonTextBox authorEmailTextBox;
        private Krypton.Toolkit.KryptonTextBox authorNameTextBox;
        private Krypton.Toolkit.KryptonLabel authorEmailLabel;
        private Krypton.Toolkit.KryptonLabel authorNameLabel;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}