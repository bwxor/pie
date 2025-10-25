namespace pie
{
    partial class BuildCommandsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildCommandsForm));
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonPage1 = new Krypton.Navigator.KryptonPage();
            buildCommandsLabel = new Krypton.Toolkit.KryptonLabel();
            removeButton = new Krypton.Toolkit.KryptonButton();
            addButton = new Krypton.Toolkit.KryptonButton();
            applyButton = new Krypton.Toolkit.KryptonButton();
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            buildCommandsListView = new BrightIdeasSoftware.ObjectListView();
            BuildCommandNameColumn = new BrightIdeasSoftware.OLVColumn();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).BeginInit();
            kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buildCommandsListView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new System.Drawing.Point(5, 9);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(149, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Custom Build Commands";
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.Items.AddRange(new object[] { "sdasd" });
            kryptonListBox1.Location = new System.Drawing.Point(10, 30);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new System.Drawing.Size(519, 184);
            kryptonListBox1.TabIndex = 0;
            // 
            // kryptonPage1
            // 
            kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            kryptonPage1.Controls.Add(kryptonLabel1);
            kryptonPage1.Controls.Add(kryptonListBox1);
            kryptonPage1.Flags = 65534;
            kryptonPage1.LastVisibleSet = true;
            kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            kryptonPage1.Name = "kryptonPage1";
            kryptonPage1.Size = new System.Drawing.Size(541, 445);
            kryptonPage1.Text = "Building";
            kryptonPage1.ToolTipTitle = "Page ToolTip";
            kryptonPage1.UniqueName = "26EE49FE8BF4430326BBCAF7F39C9913";
            // 
            // buildCommandsLabel
            // 
            buildCommandsLabel.Location = new System.Drawing.Point(5, 6);
            buildCommandsLabel.Name = "buildCommandsLabel";
            buildCommandsLabel.Size = new System.Drawing.Size(149, 20);
            buildCommandsLabel.TabIndex = 0;
            buildCommandsLabel.Values.Text = "Custom Build Commands";
            // 
            // removeButton
            // 
            removeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            removeButton.Location = new System.Drawing.Point(88, 12);
            removeButton.Name = "removeButton";
            removeButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            removeButton.Size = new System.Drawing.Size(66, 25);
            removeButton.TabIndex = 2;
            removeButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            removeButton.Values.Text = "Remove";
            removeButton.Click += kryptonButton1_Click;
            // 
            // addButton
            // 
            addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            addButton.Location = new System.Drawing.Point(16, 12);
            addButton.Name = "addButton";
            addButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addButton.Size = new System.Drawing.Size(66, 25);
            addButton.TabIndex = 3;
            addButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            addButton.Values.Text = "Add";
            addButton.Click += kryptonButton2_Click;
            // 
            // applyButton
            // 
            applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            applyButton.Location = new System.Drawing.Point(453, 12);
            applyButton.Name = "applyButton";
            applyButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            applyButton.Size = new System.Drawing.Size(66, 25);
            applyButton.TabIndex = 4;
            applyButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            applyButton.Values.Text = "Apply";
            applyButton.Click += kryptonButton3_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(buildCommandsListView);
            mainPanel.Controls.Add(buildCommandsLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(531, 395);
            mainPanel.TabIndex = 6;
            // 
            // buildCommandsListView
            // 
            buildCommandsListView.AllColumns.Add(BuildCommandNameColumn);
            buildCommandsListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buildCommandsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            buildCommandsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { BuildCommandNameColumn });
            buildCommandsListView.Location = new System.Drawing.Point(10, 29);
            buildCommandsListView.MultiSelect = false;
            buildCommandsListView.Name = "buildCommandsListView";
            buildCommandsListView.Size = new System.Drawing.Size(509, 313);
            buildCommandsListView.TabIndex = 5;
            buildCommandsListView.UseCompatibleStateImageBehavior = false;
            buildCommandsListView.View = System.Windows.Forms.View.Details;
            buildCommandsListView.DoubleClick += buildCommandsListView_DoubleClick_1;
            // 
            // BuildCommandNameColumn
            // 
            BuildCommandNameColumn.AspectName = "Name";
            BuildCommandNameColumn.CellPadding = null;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(removeButton);
            ButtonPanel.Controls.Add(applyButton);
            ButtonPanel.Controls.Add(addButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 348);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(531, 47);
            ButtonPanel.TabIndex = 7;
            // 
            // BuildCommandsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(531, 395);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BuildCommandsForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Build Commands";
            Load += BuildCommandsForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).EndInit();
            kryptonPage1.ResumeLayout(false);
            kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buildCommandsListView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Toolkit.KryptonLabel buildCommandsLabel;
        private Krypton.Toolkit.KryptonButton removeButton;
        private Krypton.Toolkit.KryptonButton addButton;
        private Krypton.Toolkit.KryptonButton applyButton;
        private Krypton.Toolkit.KryptonPanel mainPanel;
        private BrightIdeasSoftware.ObjectListView buildCommandsListView;
        private BrightIdeasSoftware.OLVColumn BuildCommandNameColumn;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
    }
}