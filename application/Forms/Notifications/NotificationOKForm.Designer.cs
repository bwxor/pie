namespace pie
{
    partial class NotificationOKForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationOKForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            contentRichTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            okButton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(contentRichTextBox);
            mainPanel.Controls.Add(okButton);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(435, 134);
            mainPanel.TabIndex = 7;
            // 
            // contentRichTextBox
            // 
            contentRichTextBox.Location = new System.Drawing.Point(4, 9);
            contentRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            contentRichTextBox.Name = "contentRichTextBox";
            contentRichTextBox.ReadOnly = true;
            contentRichTextBox.Size = new System.Drawing.Size(420, 62);
            contentRichTextBox.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            contentRichTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            contentRichTextBox.TabIndex = 5;
            contentRichTextBox.Text = "";
            // 
            // okButton
            // 
            okButton.Location = new System.Drawing.Point(344, 95);
            okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            okButton.Size = new System.Drawing.Size(74, 29);
            okButton.TabIndex = 4;
            okButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            okButton.Values.Text = "OK";
            okButton.Click += kryptonButton1_Click;
            // 
            // NotificationOKForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(435, 134);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NotificationOKForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Notification";
            Load += CustomMessageBox_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonButton okButton;
        private Krypton.Toolkit.KryptonRichTextBox contentRichTextBox;
    }
}