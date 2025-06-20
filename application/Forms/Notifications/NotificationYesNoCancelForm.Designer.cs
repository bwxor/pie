namespace pie
{
    partial class NotificationYesNoCancelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationYesNoCancelForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            contentRichTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            yesButton = new Krypton.Toolkit.KryptonButton();
            noButton = new Krypton.Toolkit.KryptonButton();
            cancelButton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(contentRichTextBox);
            mainPanel.Controls.Add(yesButton);
            mainPanel.Controls.Add(noButton);
            mainPanel.Controls.Add(cancelButton);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(431, 110);
            mainPanel.TabIndex = 8;
            // 
            // contentRichTextBox
            // 
            contentRichTextBox.Location = new System.Drawing.Point(4, 9);
            contentRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            contentRichTextBox.Name = "contentRichTextBox";
            contentRichTextBox.ReadOnly = true;
            contentRichTextBox.Size = new System.Drawing.Size(420, 52);
            contentRichTextBox.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            contentRichTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            contentRichTextBox.TabIndex = 3;
            contentRichTextBox.Text = "";
            // 
            // yesButton
            // 
            yesButton.Location = new System.Drawing.Point(183, 74);
            yesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            yesButton.Name = "yesButton";
            yesButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            yesButton.Size = new System.Drawing.Size(74, 29);
            yesButton.TabIndex = 0;
            yesButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            yesButton.Values.Text = "Yes";
            yesButton.Click += kryptonButton3_Click;
            // 
            // noButton
            // 
            noButton.Location = new System.Drawing.Point(264, 74);
            noButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            noButton.Name = "noButton";
            noButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            noButton.Size = new System.Drawing.Size(74, 29);
            noButton.TabIndex = 1;
            noButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            noButton.Values.Text = "No";
            noButton.Click += kryptonButton2_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(344, 74);
            cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cancelButton.Size = new System.Drawing.Size(74, 29);
            cancelButton.TabIndex = 2;
            cancelButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            cancelButton.Values.Text = "Cancel";
            cancelButton.Click += kryptonButton1_Click;
            // 
            // NotificationYesNoCancelForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(431, 110);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "NotificationYesNoCancelForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Notification";
            Load += NotificationYesNoCancel_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonButton yesButton;
        private Krypton.Toolkit.KryptonButton noButton;
        private Krypton.Toolkit.KryptonButton cancelButton;
        private Krypton.Toolkit.KryptonRichTextBox contentRichTextBox;
    }
}