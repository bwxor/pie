namespace pie.Forms.Git
{
    partial class GitCommitMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitCommitMessageForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            commitMessageRichTextBox = new Krypton.Toolkit.KryptonRichTextBox();
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
            mainPanel.Controls.Add(commitMessageRichTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(359, 199);
            mainPanel.TabIndex = 3;
            // 
            // commitMessageRichTextBox
            // 
            commitMessageRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            commitMessageRichTextBox.Location = new System.Drawing.Point(3, 12);
            commitMessageRichTextBox.Name = "commitMessageRichTextBox";
            commitMessageRichTextBox.Size = new System.Drawing.Size(353, 133);
            commitMessageRichTextBox.TabIndex = 3;
            commitMessageRichTextBox.Text = "";
            commitMessageRichTextBox.KeyDown += commitMessageRichTextBox_KeyDown;
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(280, 11);
            saveButton.MinimumSize = new System.Drawing.Size(0, 29);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(76, 29);
            saveButton.TabIndex = 1;
            saveButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            saveButton.Values.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(saveButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 156);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(359, 43);
            ButtonPanel.TabIndex = 4;
            // 
            // GitCommitMessageForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(359, 199);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GitCommitMessageForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Commit Message";
            Load += GitCommitMessageForm_Load;
            KeyDown += GitCommitMessageForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonButton saveButton;
        private Krypton.Toolkit.KryptonRichTextBox commitMessageRichTextBox;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}