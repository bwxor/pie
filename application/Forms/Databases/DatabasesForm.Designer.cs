namespace pie.Forms.Databases
{
    partial class DatabasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabasesForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            databasesListView = new BrightIdeasSoftware.ObjectListView();
            ConnectionNameColumn = new BrightIdeasSoftware.OLVColumn();
            databaseConnectionsLabel = new Krypton.Toolkit.KryptonLabel();
            applyButton = new Krypton.Toolkit.KryptonButton();
            removeButton = new Krypton.Toolkit.KryptonButton();
            addButton = new Krypton.Toolkit.KryptonButton();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databasesListView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(databasesListView);
            mainPanel.Controls.Add(databaseConnectionsLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(499, 367);
            mainPanel.TabIndex = 7;
            // 
            // databasesListView
            // 
            databasesListView.AllColumns.Add(ConnectionNameColumn);
            databasesListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            databasesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            databasesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ConnectionNameColumn });
            databasesListView.Location = new System.Drawing.Point(12, 33);
            databasesListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databasesListView.MultiSelect = false;
            databasesListView.Name = "databasesListView";
            databasesListView.Size = new System.Drawing.Size(475, 279);
            databasesListView.TabIndex = 5;
            databasesListView.UseCompatibleStateImageBehavior = false;
            databasesListView.View = System.Windows.Forms.View.Details;
            databasesListView.DoubleClick += databasesListView_DoubleClick;
            // 
            // ConnectionNameColumn
            // 
            ConnectionNameColumn.AspectName = "Name";
            ConnectionNameColumn.CellPadding = null;
            // 
            // databaseConnectionsLabel
            // 
            databaseConnectionsLabel.Location = new System.Drawing.Point(6, 7);
            databaseConnectionsLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseConnectionsLabel.Name = "databaseConnectionsLabel";
            databaseConnectionsLabel.Size = new System.Drawing.Size(132, 20);
            databaseConnectionsLabel.TabIndex = 0;
            databaseConnectionsLabel.Values.Text = "Database Connections";
            // 
            // applyButton
            // 
            applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            applyButton.Location = new System.Drawing.Point(408, 12);
            applyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            applyButton.Name = "applyButton";
            applyButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            applyButton.Size = new System.Drawing.Size(77, 29);
            applyButton.TabIndex = 4;
            applyButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            applyButton.Values.Text = "Apply";
            applyButton.Click += kryptonButton3_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            removeButton.Location = new System.Drawing.Point(98, 12);
            removeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            removeButton.Name = "removeButton";
            removeButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            removeButton.Size = new System.Drawing.Size(77, 29);
            removeButton.TabIndex = 2;
            removeButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            removeButton.Values.Text = "Remove";
            removeButton.Click += kryptonButton1_Click;
            // 
            // addButton
            // 
            addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            addButton.Location = new System.Drawing.Point(14, 12);
            addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addButton.Size = new System.Drawing.Size(77, 29);
            addButton.TabIndex = 3;
            addButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            addButton.Values.Text = "Add";
            addButton.Click += kryptonButton2_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(applyButton);
            ButtonPanel.Controls.Add(addButton);
            ButtonPanel.Controls.Add(removeButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 318);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(499, 49);
            ButtonPanel.TabIndex = 8;
            // 
            // DatabasesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(499, 367);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "DatabasesForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Databases";
            Load += DatabasesForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databasesListView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private BrightIdeasSoftware.ObjectListView databasesListView;
        private BrightIdeasSoftware.OLVColumn ConnectionNameColumn;
        private Krypton.Toolkit.KryptonButton applyButton;
        private Krypton.Toolkit.KryptonLabel databaseConnectionsLabel;
        private Krypton.Toolkit.KryptonButton removeButton;
        private Krypton.Toolkit.KryptonButton addButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}