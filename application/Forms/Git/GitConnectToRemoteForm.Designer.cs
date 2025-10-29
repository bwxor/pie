namespace pie.Forms.Git
{
    partial class GitConnectToRemoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitConnectToRemoteForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            repositoryURLLabel = new Krypton.Toolkit.KryptonLabel();
            repositoryURLTextBox = new Krypton.Toolkit.KryptonTextBox();
            connectButton = new Krypton.Toolkit.KryptonButton();
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
            mainPanel.Controls.Add(repositoryURLLabel);
            mainPanel.Controls.Add(repositoryURLTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(472, 101);
            mainPanel.TabIndex = 4;
            // 
            // repositoryURLLabel
            // 
            repositoryURLLabel.Location = new System.Drawing.Point(8, 6);
            repositoryURLLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            repositoryURLLabel.Name = "repositoryURLLabel";
            repositoryURLLabel.Size = new System.Drawing.Size(94, 20);
            repositoryURLLabel.TabIndex = 4;
            repositoryURLLabel.Values.Text = "Repository URL";
            // 
            // repositoryURLTextBox
            // 
            repositoryURLTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            repositoryURLTextBox.Location = new System.Drawing.Point(14, 29);
            repositoryURLTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            repositoryURLTextBox.Name = "repositoryURLTextBox";
            repositoryURLTextBox.Size = new System.Drawing.Size(444, 23);
            repositoryURLTextBox.TabIndex = 2;
            repositoryURLTextBox.KeyDown += repositoryURLTextBox_KeyDown;
            // 
            // connectButton
            // 
            connectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            connectButton.Location = new System.Drawing.Point(370, 4);
            connectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            connectButton.MinimumSize = new System.Drawing.Size(0, 29);
            connectButton.Name = "connectButton";
            connectButton.Size = new System.Drawing.Size(89, 29);
            connectButton.TabIndex = 6;
            connectButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            connectButton.Values.Text = "Connect";
            connectButton.Click += connectButton_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(connectButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 65);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(472, 36);
            ButtonPanel.TabIndex = 5;
            // 
            // GitConnectToRemoteForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(472, 101);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GitConnectToRemoteForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Connect to remote repository";
            Load += GitConnectToRemoteForm_Load;
            KeyDown += GitConnectToRemoteForm_KeyDown;
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
        private Krypton.Toolkit.KryptonButton connectButton;
        private Krypton.Toolkit.KryptonLabel repositoryURLLabel;
        private Krypton.Toolkit.KryptonTextBox repositoryURLTextBox;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}