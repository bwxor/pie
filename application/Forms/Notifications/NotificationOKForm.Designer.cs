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
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            okButton = new Krypton.Toolkit.KryptonButton();
            contentRichTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(ButtonPanel);
            mainPanel.Controls.Add(contentRichTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(5);
            mainPanel.Size = new System.Drawing.Size(471, 133);
            mainPanel.TabIndex = 7;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(okButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(5, 86);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(461, 42);
            ButtonPanel.TabIndex = 6;
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.Location = new System.Drawing.Point(387, 8);
            okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            okButton.MinimumSize = new System.Drawing.Size(0, 29);
            okButton.Name = "okButton";
            okButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            okButton.Size = new System.Drawing.Size(74, 29);
            okButton.TabIndex = 4;
            okButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            okButton.Values.Text = "OK";
            okButton.Click += kryptonButton1_Click;
            // 
            // contentRichTextBox
            // 
            contentRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            contentRichTextBox.Location = new System.Drawing.Point(5, 5);
            contentRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            contentRichTextBox.Name = "contentRichTextBox";
            contentRichTextBox.ReadOnly = true;
            contentRichTextBox.Size = new System.Drawing.Size(461, 123);
            contentRichTextBox.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            contentRichTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            contentRichTextBox.TabIndex = 5;
            contentRichTextBox.Text = "";
            contentRichTextBox.KeyDown += contentRichTextBox_KeyDown;
            // 
            // NotificationOKForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(471, 133);
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
            KeyDown += NotificationOKForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonButton okButton;
        private Krypton.Toolkit.KryptonRichTextBox contentRichTextBox;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}