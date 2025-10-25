namespace pie.Forms.Format
{
    partial class FormatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            formatOptionsListView = new BrightIdeasSoftware.ObjectListView();
            FormatOptionNameColumn = new BrightIdeasSoftware.OLVColumn();
            FormatOptionCategoryColumn = new BrightIdeasSoftware.OLVColumn();
            FormatOptionDescriptionColumn = new BrightIdeasSoftware.OLVColumn();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formatOptionsListView).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(kryptonTextBox1);
            mainPanel.Controls.Add(formatOptionsListView);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(819, 417);
            mainPanel.TabIndex = 7;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            kryptonTextBox1.Location = new System.Drawing.Point(12, 12);
            kryptonTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new System.Drawing.Size(796, 23);
            kryptonTextBox1.TabIndex = 6;
            kryptonTextBox1.Text = "Search...";
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // formatOptionsListView
            // 
            formatOptionsListView.AllColumns.Add(FormatOptionNameColumn);
            formatOptionsListView.AllColumns.Add(FormatOptionCategoryColumn);
            formatOptionsListView.AllColumns.Add(FormatOptionDescriptionColumn);
            formatOptionsListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            formatOptionsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            formatOptionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { FormatOptionNameColumn, FormatOptionCategoryColumn, FormatOptionDescriptionColumn });
            formatOptionsListView.HeaderUsesThemes = false;
            formatOptionsListView.Location = new System.Drawing.Point(12, 48);
            formatOptionsListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            formatOptionsListView.MultiSelect = false;
            formatOptionsListView.Name = "formatOptionsListView";
            formatOptionsListView.SelectColumnsOnRightClick = false;
            formatOptionsListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            formatOptionsListView.Size = new System.Drawing.Size(795, 355);
            formatOptionsListView.TabIndex = 5;
            formatOptionsListView.UseCompatibleStateImageBehavior = false;
            formatOptionsListView.View = System.Windows.Forms.View.Details;
            formatOptionsListView.DoubleClick += formatOptionsListView_DoubleClick;
            // 
            // FormatOptionNameColumn
            // 
            FormatOptionNameColumn.AspectName = "Name";
            FormatOptionNameColumn.CellPadding = null;
            FormatOptionNameColumn.Text = "Name";
            FormatOptionNameColumn.Width = 199;
            // 
            // FormatOptionCategoryColumn
            // 
            FormatOptionCategoryColumn.AspectName = "Category";
            FormatOptionCategoryColumn.CellPadding = null;
            FormatOptionCategoryColumn.Text = "Category";
            // 
            // FormatOptionDescriptionColumn
            // 
            FormatOptionDescriptionColumn.AspectName = "Description";
            FormatOptionDescriptionColumn.CellPadding = null;
            FormatOptionDescriptionColumn.Text = "Description";
            // 
            // FormatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(819, 417);
            Controls.Add(mainPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormatForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Format";
            Load += FormatForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formatOptionsListView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private BrightIdeasSoftware.ObjectListView formatOptionsListView;
        private BrightIdeasSoftware.OLVColumn FormatOptionNameColumn;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private BrightIdeasSoftware.OLVColumn FormatOptionCategoryColumn;
        private BrightIdeasSoftware.OLVColumn FormatOptionDescriptionColumn;
    }
}