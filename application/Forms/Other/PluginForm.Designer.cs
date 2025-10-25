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
            DynamicTableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
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
            // DynamicTableLayoutPanel
            // 
            DynamicTableLayoutPanel.AutoSize = true;
            DynamicTableLayoutPanel.ColumnCount = 1;
            DynamicTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            DynamicTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            DynamicTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            DynamicTableLayoutPanel.Name = "DynamicTableLayoutPanel";
            DynamicTableLayoutPanel.RowCount = 1;
            DynamicTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            DynamicTableLayoutPanel.Size = new System.Drawing.Size(526, 0);
            DynamicTableLayoutPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(ApplyButton);
            kryptonPanel1.Controls.Add(CancelButton);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            kryptonPanel1.Location = new System.Drawing.Point(2, 230);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(526, 51);
            kryptonPanel1.TabIndex = 2;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new System.Drawing.Point(351, 21);
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
            CancelButton.Location = new System.Drawing.Point(432, 21);
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
            kryptonPanel2.AutoSize = true;
            kryptonPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            kryptonPanel2.Controls.Add(DynamicTableLayoutPanel);
            kryptonPanel2.Controls.Add(kryptonPanel1);
            kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Padding = new System.Windows.Forms.Padding(2);
            kryptonPanel2.Size = new System.Drawing.Size(530, 283);
            kryptonPanel2.TabIndex = 4;
            // 
            // PluginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(530, 283);
            Controls.Add(kryptonPanel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(535, 50);
            Name = "PluginForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PluginForm";
            Load += PluginForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTableLayoutPanel DynamicTableLayoutPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton CancelButton;
        private Krypton.Toolkit.KryptonButton ApplyButton;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}