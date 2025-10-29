namespace pie.Forms.Theme
{
    partial class NewThemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewThemeForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            themeNameLabel = new Krypton.Toolkit.KryptonLabel();
            themeNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            createButton = new Krypton.Toolkit.KryptonButton();
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
            mainPanel.Controls.Add(themeNameLabel);
            mainPanel.Controls.Add(themeNameTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(372, 101);
            mainPanel.TabIndex = 4;
            // 
            // themeNameLabel
            // 
            themeNameLabel.Location = new System.Drawing.Point(10, 6);
            themeNameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            themeNameLabel.Name = "themeNameLabel";
            themeNameLabel.Size = new System.Drawing.Size(84, 20);
            themeNameLabel.TabIndex = 4;
            themeNameLabel.Values.Text = "Theme Name";
            // 
            // themeNameTextBox
            // 
            themeNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            themeNameTextBox.Location = new System.Drawing.Point(13, 30);
            themeNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            themeNameTextBox.Name = "themeNameTextBox";
            themeNameTextBox.Size = new System.Drawing.Size(344, 23);
            themeNameTextBox.TabIndex = 2;
            // 
            // createButton
            // 
            createButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            createButton.Location = new System.Drawing.Point(268, 8);
            createButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            createButton.MinimumSize = new System.Drawing.Size(0, 29);
            createButton.Name = "createButton";
            createButton.Size = new System.Drawing.Size(89, 29);
            createButton.TabIndex = 1;
            createButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            createButton.Values.Text = "Create";
            createButton.Click += kryptonButton1_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(createButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 61);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(372, 40);
            ButtonPanel.TabIndex = 5;
            // 
            // NewThemeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(372, 101);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NewThemeForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add Theme";
            Load += NewThemeForm_Load;
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
        private Krypton.Toolkit.KryptonLabel themeNameLabel;
        private Krypton.Toolkit.KryptonTextBox themeNameTextBox;
        private Krypton.Toolkit.KryptonButton createButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}