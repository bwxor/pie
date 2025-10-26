namespace pie.Forms.Git
{
    partial class NewBranchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBranchForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            branchNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            branchNameLabel = new Krypton.Toolkit.KryptonLabel();
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
            mainPanel.Controls.Add(branchNameTextBox);
            mainPanel.Controls.Add(branchNameLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(378, 133);
            mainPanel.TabIndex = 9;
            // 
            // branchNameTextBox
            // 
            branchNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            branchNameTextBox.Location = new System.Drawing.Point(9, 37);
            branchNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            branchNameTextBox.Name = "branchNameTextBox";
            branchNameTextBox.Size = new System.Drawing.Size(365, 23);
            branchNameTextBox.TabIndex = 0;
            branchNameTextBox.KeyDown += branchNameTextBox_KeyDown;
            // 
            // branchNameLabel
            // 
            branchNameLabel.Location = new System.Drawing.Point(5, 13);
            branchNameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new System.Drawing.Size(84, 20);
            branchNameLabel.TabIndex = 2;
            branchNameLabel.Values.Text = "Branch Name";
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(282, 3);
            saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            saveButton.Size = new System.Drawing.Size(92, 29);
            saveButton.TabIndex = 4;
            saveButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            saveButton.Values.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(saveButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 95);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(378, 38);
            ButtonPanel.TabIndex = 10;
            // 
            // NewBranchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(378, 133);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "NewBranchForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "New Branch";
            Load += NewBranchForm_Load;
            KeyDown += NewBranchForm_KeyDown;
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
        private Krypton.Toolkit.KryptonTextBox branchNameTextBox;
        private Krypton.Toolkit.KryptonLabel branchNameLabel;
        private Krypton.Toolkit.KryptonButton saveButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}