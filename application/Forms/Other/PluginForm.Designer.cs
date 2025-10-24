namespace pie.Forms.Other
{
    partial class PluginForm
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
            TableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ApplyButton = new Krypton.Toolkit.KryptonButton();
            CancelButton = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            TableLayoutPanel.Size = new System.Drawing.Size(457, 340);
            TableLayoutPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(ApplyButton);
            kryptonPanel1.Controls.Add(CancelButton);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            kryptonPanel1.Location = new System.Drawing.Point(0, 360);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(477, 50);
            kryptonPanel1.TabIndex = 2;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new System.Drawing.Point(311, 18);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new System.Drawing.Size(75, 25);
            ApplyButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ApplyButton.TabIndex = 4;
            ApplyButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            ApplyButton.Values.Text = "Apply";
            ApplyButton.Click += ApplyButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(392, 18);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 25);
            CancelButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelButton.TabIndex = 3;
            CancelButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            CancelButton.Values.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(TableLayoutPanel);
            kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Padding = new System.Windows.Forms.Padding(10);
            kryptonPanel2.Size = new System.Drawing.Size(477, 360);
            kryptonPanel2.TabIndex = 4;
            // 
            // PluginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(477, 410);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "PluginForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PluginForm";
            Load += PluginForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonTableLayoutPanel TableLayoutPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton CancelButton;
        private Krypton.Toolkit.KryptonButton ApplyButton;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}