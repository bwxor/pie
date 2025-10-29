namespace pie
{
    partial class AddBuildCommandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBuildCommandForm));
            displayNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            commandTextBox = new Krypton.Toolkit.KryptonTextBox();
            displayNameLabel = new Krypton.Toolkit.KryptonLabel();
            commandLabel = new Krypton.Toolkit.KryptonLabel();
            saveButton = new Krypton.Toolkit.KryptonButton();
            commandTipLabel = new Krypton.Toolkit.KryptonLabel();
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            fileExtensionsTipLabel = new Krypton.Toolkit.KryptonLabel();
            fileExtensionsRichTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // displayNameTextBox
            // 
            displayNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            displayNameTextBox.Location = new System.Drawing.Point(8, 29);
            displayNameTextBox.Name = "displayNameTextBox";
            displayNameTextBox.Size = new System.Drawing.Size(374, 23);
            displayNameTextBox.TabIndex = 0;
            // 
            // commandTextBox
            // 
            commandTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            commandTextBox.Location = new System.Drawing.Point(8, 79);
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new System.Drawing.Size(374, 23);
            commandTextBox.TabIndex = 1;
            // 
            // displayNameLabel
            // 
            displayNameLabel.Location = new System.Drawing.Point(4, 8);
            displayNameLabel.Name = "displayNameLabel";
            displayNameLabel.Size = new System.Drawing.Size(86, 20);
            displayNameLabel.TabIndex = 2;
            displayNameLabel.Values.Text = "Display Name";
            // 
            // commandLabel
            // 
            commandLabel.Location = new System.Drawing.Point(4, 58);
            commandLabel.Name = "commandLabel";
            commandLabel.Size = new System.Drawing.Size(67, 20);
            commandLabel.TabIndex = 3;
            commandLabel.Values.Text = "Command";
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(301, 6);
            saveButton.MinimumSize = new System.Drawing.Size(0, 24);
            saveButton.Name = "saveButton";
            saveButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            saveButton.Size = new System.Drawing.Size(79, 24);
            saveButton.TabIndex = 3;
            saveButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            saveButton.Values.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // commandTipLabel
            // 
            commandTipLabel.Location = new System.Drawing.Point(4, 105);
            commandTipLabel.Name = "commandTipLabel";
            commandTipLabel.Size = new System.Drawing.Size(274, 14);
            commandTipLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            commandTipLabel.TabIndex = 5;
            commandTipLabel.Values.Text = "$FILE can be used as a placeholder for the currently opened file.";
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(fileExtensionsTipLabel);
            mainPanel.Controls.Add(fileExtensionsRichTextBox);
            mainPanel.Controls.Add(kryptonLabel5);
            mainPanel.Controls.Add(commandTextBox);
            mainPanel.Controls.Add(commandTipLabel);
            mainPanel.Controls.Add(displayNameTextBox);
            mainPanel.Controls.Add(displayNameLabel);
            mainPanel.Controls.Add(commandLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(390, 309);
            mainPanel.TabIndex = 6;
            // 
            // fileExtensionsTipLabel
            // 
            fileExtensionsTipLabel.Location = new System.Drawing.Point(4, 246);
            fileExtensionsTipLabel.Name = "fileExtensionsTipLabel";
            fileExtensionsTipLabel.Size = new System.Drawing.Size(131, 14);
            fileExtensionsTipLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            fileExtensionsTipLabel.TabIndex = 10;
            fileExtensionsTipLabel.Values.Text = "Leave blank to match all files.";
            // 
            // fileExtensionsRichTextBox
            // 
            fileExtensionsRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fileExtensionsRichTextBox.Location = new System.Drawing.Point(8, 146);
            fileExtensionsRichTextBox.Name = "fileExtensionsRichTextBox";
            fileExtensionsRichTextBox.Size = new System.Drawing.Size(374, 96);
            fileExtensionsRichTextBox.TabIndex = 2;
            fileExtensionsRichTextBox.Text = "";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new System.Drawing.Point(4, 125);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new System.Drawing.Size(152, 20);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Associated File Extensions";
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(saveButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 266);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(390, 43);
            ButtonPanel.TabIndex = 7;
            // 
            // AddBuildCommandForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(390, 309);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBuildCommandForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add / Edit Build Command";
            Load += AddBuildCommandForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox displayNameTextBox;
        private Krypton.Toolkit.KryptonTextBox commandTextBox;
        private Krypton.Toolkit.KryptonLabel displayNameLabel;
        private Krypton.Toolkit.KryptonLabel commandLabel;
        private Krypton.Toolkit.KryptonButton saveButton;
        private Krypton.Toolkit.KryptonLabel commandTipLabel;
        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonRichTextBox fileExtensionsRichTextBox;
        private Krypton.Toolkit.KryptonLabel fileExtensionsTipLabel;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}