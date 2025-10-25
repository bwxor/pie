namespace pie.Forms.Git
{
    partial class GitMergeBranchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitMergeBranchForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            branchComboBox = new Krypton.Toolkit.KryptonComboBox();
            mergeButton = new Krypton.Toolkit.KryptonButton();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)branchComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(branchComboBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(351, 89);
            mainPanel.TabIndex = 4;
            // 
            // branchComboBox
            // 
            branchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            branchComboBox.DropDownWidth = 370;
            branchComboBox.Location = new System.Drawing.Point(3, 12);
            branchComboBox.Name = "branchComboBox";
            branchComboBox.Size = new System.Drawing.Size(338, 22);
            branchComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            branchComboBox.TabIndex = 2;
            branchComboBox.Text = "kryptonComboBox1";
            // 
            // mergeButton
            // 
            mergeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            mergeButton.Location = new System.Drawing.Point(265, 9);
            mergeButton.Name = "mergeButton";
            mergeButton.Size = new System.Drawing.Size(76, 25);
            mergeButton.TabIndex = 1;
            mergeButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            mergeButton.Values.Text = "Merge";
            mergeButton.Click += mergeButton_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(mergeButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 50);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(351, 39);
            ButtonPanel.TabIndex = 5;
            // 
            // GitMergeBranchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(351, 89);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GitMergeBranchForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Merge branch into...";
            Load += GitMergeBranchForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)branchComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonRichTextBox commitMessageRichTextBox;
        private Krypton.Toolkit.KryptonButton mergeButton;
        private Krypton.Toolkit.KryptonComboBox branchComboBox;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}