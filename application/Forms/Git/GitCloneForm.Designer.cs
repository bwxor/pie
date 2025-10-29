namespace pie
{
    partial class GitCloneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitCloneForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            cloneIntoLabel = new Krypton.Toolkit.KryptonLabel();
            repositoryURLLabel = new Krypton.Toolkit.KryptonLabel();
            cloneIntoTextBox = new Krypton.Toolkit.KryptonTextBox();
            repositoryURLTextBox = new Krypton.Toolkit.KryptonTextBox();
            browseButton = new Krypton.Toolkit.KryptonButton();
            cloneButton = new Krypton.Toolkit.KryptonButton();
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
            mainPanel.Controls.Add(cloneIntoLabel);
            mainPanel.Controls.Add(repositoryURLLabel);
            mainPanel.Controls.Add(cloneIntoTextBox);
            mainPanel.Controls.Add(repositoryURLTextBox);
            mainPanel.Controls.Add(browseButton);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(621, 169);
            mainPanel.TabIndex = 3;
            // 
            // cloneIntoLabel
            // 
            cloneIntoLabel.Location = new System.Drawing.Point(8, 60);
            cloneIntoLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cloneIntoLabel.Name = "cloneIntoLabel";
            cloneIntoLabel.Size = new System.Drawing.Size(67, 20);
            cloneIntoLabel.TabIndex = 5;
            cloneIntoLabel.Values.Text = "Clone into";
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
            // cloneIntoTextBox
            // 
            cloneIntoTextBox.Location = new System.Drawing.Point(14, 83);
            cloneIntoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cloneIntoTextBox.Name = "cloneIntoTextBox";
            cloneIntoTextBox.Size = new System.Drawing.Size(473, 23);
            cloneIntoTextBox.TabIndex = 3;
            cloneIntoTextBox.KeyDown += cloneIntoTextBox_KeyDown;
            // 
            // repositoryURLTextBox
            // 
            repositoryURLTextBox.Location = new System.Drawing.Point(14, 29);
            repositoryURLTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            repositoryURLTextBox.Name = "repositoryURLTextBox";
            repositoryURLTextBox.Size = new System.Drawing.Size(473, 23);
            repositoryURLTextBox.TabIndex = 2;
            repositoryURLTextBox.KeyDown += repositoryURLTextBox_KeyDown;
            // 
            // browseButton
            // 
            browseButton.Location = new System.Drawing.Point(495, 82);
            browseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            browseButton.MinimumSize = new System.Drawing.Size(0, 28);
            browseButton.Name = "browseButton";
            browseButton.Size = new System.Drawing.Size(89, 28);
            browseButton.TabIndex = 1;
            browseButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            browseButton.Values.Text = "Browse";
            browseButton.Click += kryptonButton1_Click_1;
            // 
            // cloneButton
            // 
            cloneButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cloneButton.Location = new System.Drawing.Point(519, 6);
            cloneButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cloneButton.MinimumSize = new System.Drawing.Size(0, 29);
            cloneButton.Name = "cloneButton";
            cloneButton.Size = new System.Drawing.Size(89, 29);
            cloneButton.TabIndex = 6;
            cloneButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            cloneButton.Values.Text = "Clone";
            cloneButton.Click += kryptonButton2_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(cloneButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 131);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(621, 38);
            ButtonPanel.TabIndex = 4;
            // 
            // GitCloneForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(621, 169);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "GitCloneForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Git Clone";
            Load += GitCloneForm_Load;
            KeyDown += GitCloneForm_KeyDown;
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
        private Krypton.Toolkit.KryptonButton cloneButton;
        private Krypton.Toolkit.KryptonLabel cloneIntoLabel;
        private Krypton.Toolkit.KryptonLabel repositoryURLLabel;
        private Krypton.Toolkit.KryptonTextBox cloneIntoTextBox;
        private Krypton.Toolkit.KryptonTextBox repositoryURLTextBox;
        private Krypton.Toolkit.KryptonButton browseButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}