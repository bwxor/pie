namespace pie
{
    partial class NotificationFatalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationFatalForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            titleLabel = new Krypton.Toolkit.KryptonLabel();
            okButton = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(kryptonLabel1);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(382, 337);
            mainPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(192, 0, 0);
            mainPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(192, 0, 0);
            mainPanel.TabIndex = 7;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new System.Drawing.Point(4, 50);
            kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(353, 100);
            kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            kryptonLabel1.TabIndex = 8;
            kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // titleLabel
            // 
            titleLabel.Location = new System.Drawing.Point(0, 10);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(328, 33);
            titleLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            titleLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            titleLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            titleLabel.TabIndex = 5;
            titleLabel.Values.Text = "Oops... something's not right";
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.Location = new System.Drawing.Point(304, 30);
            okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            okButton.Size = new System.Drawing.Size(74, 29);
            okButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            okButton.TabIndex = 6;
            okButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            okButton.Values.Text = "OK";
            okButton.Click += okButton_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(okButton);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            kryptonPanel1.Location = new System.Drawing.Point(0, 266);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(382, 71);
            kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(192, 0, 0);
            kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(192, 0, 0);
            kryptonPanel1.TabIndex = 8;
            // 
            // NotificationFatalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(382, 337);
            ControlBox = false;
            Controls.Add(kryptonPanel1);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NotificationFatalForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(192, 0, 0);
            StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(192, 0, 0);
            StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(192, 0, 0);
            StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(192, 0, 0);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(192, 0, 0);
            StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(192, 0, 0);
            StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            Text = "Fatal Error";
            FormClosing += NotificationFatalForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonLabel titleLabel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton okButton;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}