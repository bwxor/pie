namespace pie
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            versionLabel = new Krypton.Toolkit.KryptonLabel();
            titleLabel = new Krypton.Toolkit.KryptonLabel();
            descriptionLabel = new Krypton.Toolkit.KryptonLabel();
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            iconPictureBox = new System.Windows.Forms.PictureBox();
            websiteButton = new Krypton.Toolkit.KryptonButton();
            repoButton = new Krypton.Toolkit.KryptonButton();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // versionLabel
            // 
            versionLabel.LabelStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            versionLabel.Location = new System.Drawing.Point(5, 44);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(58, 22);
            versionLabel.TabIndex = 2;
            versionLabel.Values.Text = "Version x";
            // 
            // titleLabel
            // 
            titleLabel.Location = new System.Drawing.Point(2, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(105, 33);
            titleLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            titleLabel.TabIndex = 5;
            titleLabel.Values.Text = "pie Beta";
            // 
            // descriptionLabel
            // 
            descriptionLabel.LabelStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            descriptionLabel.Location = new System.Drawing.Point(5, 70);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(349, 118);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Values.Text = resources.GetString("descriptionLabel.Values.Text");
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(iconPictureBox);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(versionLabel);
            mainPanel.Controls.Add(descriptionLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(360, 274);
            mainPanel.TabIndex = 6;
            // 
            // iconPictureBox
            // 
            iconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            iconPictureBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("iconPictureBox.BackgroundImage");
            iconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            iconPictureBox.Location = new System.Drawing.Point(301, 8);
            iconPictureBox.Name = "iconPictureBox";
            iconPictureBox.Size = new System.Drawing.Size(51, 48);
            iconPictureBox.TabIndex = 6;
            iconPictureBox.TabStop = false;
            // 
            // websiteButton
            // 
            websiteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            websiteButton.Location = new System.Drawing.Point(242, 17);
            websiteButton.MinimumSize = new System.Drawing.Size(0, 29);
            websiteButton.Name = "websiteButton";
            websiteButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            websiteButton.Size = new System.Drawing.Size(113, 29);
            websiteButton.TabIndex = 8;
            websiteButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            websiteButton.Values.Text = "Author's Website";
            websiteButton.Click += kryptonButton2_Click;
            // 
            // repoButton
            // 
            repoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            repoButton.Location = new System.Drawing.Point(123, 17);
            repoButton.MinimumSize = new System.Drawing.Size(0, 29);
            repoButton.Name = "repoButton";
            repoButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            repoButton.Size = new System.Drawing.Size(113, 29);
            repoButton.TabIndex = 7;
            repoButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            repoButton.Values.Text = "GitHub Repo";
            repoButton.Click += kryptonButton1_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(websiteButton);
            ButtonPanel.Controls.Add(repoButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 224);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(360, 50);
            ButtonPanel.TabIndex = 7;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(360, 274);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About";
            Load += AboutForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel versionLabel;
        private Krypton.Toolkit.KryptonLabel titleLabel;
        private Krypton.Toolkit.KryptonLabel descriptionLabel;
        private Krypton.Toolkit.KryptonPanel mainPanel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private Krypton.Toolkit.KryptonButton repoButton;
        private Krypton.Toolkit.KryptonButton websiteButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}