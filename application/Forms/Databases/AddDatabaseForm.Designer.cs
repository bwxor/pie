namespace pie.Forms.Databases
{
    partial class AddDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDatabaseForm));
            mainPanel = new Krypton.Toolkit.KryptonPanel();
            postgresqlCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            mssqlCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            mysqlCheckButton = new Krypton.Toolkit.KryptonCheckButton();
            typeLabel = new Krypton.Toolkit.KryptonLabel();
            hostnameTipLabel = new Krypton.Toolkit.KryptonLabel();
            databaseConnectionNameTipLabel = new Krypton.Toolkit.KryptonLabel();
            databasePasswordTextBox = new Krypton.Toolkit.KryptonTextBox();
            passwordLabel = new Krypton.Toolkit.KryptonLabel();
            databaseUsernameTextBox = new Krypton.Toolkit.KryptonTextBox();
            usernameLabel = new Krypton.Toolkit.KryptonLabel();
            databaseNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            databaseNameLabel = new Krypton.Toolkit.KryptonLabel();
            databasePortTextBox = new Krypton.Toolkit.KryptonTextBox();
            portLabel = new Krypton.Toolkit.KryptonLabel();
            databaseHostnameTextBox = new Krypton.Toolkit.KryptonTextBox();
            databaseConnectionNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            databaseConnectionNameLabel = new Krypton.Toolkit.KryptonLabel();
            hostnameLabel = new Krypton.Toolkit.KryptonLabel();
            testConnectionButton = new Krypton.Toolkit.KryptonButton();
            saveButton = new Krypton.Toolkit.KryptonButton();
            ButtonPanel = new Krypton.Toolkit.KryptonPanel();
            databasesPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)mainPanel).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).BeginInit();
            ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databasesPanel).BeginInit();
            databasesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(databasesPanel);
            mainPanel.Controls.Add(typeLabel);
            mainPanel.Controls.Add(hostnameTipLabel);
            mainPanel.Controls.Add(databaseConnectionNameTipLabel);
            mainPanel.Controls.Add(databasePasswordTextBox);
            mainPanel.Controls.Add(passwordLabel);
            mainPanel.Controls.Add(databaseUsernameTextBox);
            mainPanel.Controls.Add(usernameLabel);
            mainPanel.Controls.Add(databaseNameTextBox);
            mainPanel.Controls.Add(databaseNameLabel);
            mainPanel.Controls.Add(databasePortTextBox);
            mainPanel.Controls.Add(portLabel);
            mainPanel.Controls.Add(databaseHostnameTextBox);
            mainPanel.Controls.Add(databaseConnectionNameTextBox);
            mainPanel.Controls.Add(databaseConnectionNameLabel);
            mainPanel.Controls.Add(hostnameLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(501, 502);
            mainPanel.TabIndex = 7;
            // 
            // postgresqlCheckButton
            // 
            postgresqlCheckButton.Location = new System.Drawing.Point(321, 2);
            postgresqlCheckButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            postgresqlCheckButton.MinimumSize = new System.Drawing.Size(0, 57);
            postgresqlCheckButton.Name = "postgresqlCheckButton";
            postgresqlCheckButton.Size = new System.Drawing.Size(149, 57);
            postgresqlCheckButton.TabIndex = 20;
            postgresqlCheckButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            postgresqlCheckButton.Values.Image = Properties.Resources.postgresql_black;
            postgresqlCheckButton.Values.Text = "PostgreSQL";
            postgresqlCheckButton.Click += kryptonCheckButton1_Click;
            // 
            // mssqlCheckButton
            // 
            mssqlCheckButton.Location = new System.Drawing.Point(165, 2);
            mssqlCheckButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mssqlCheckButton.MinimumSize = new System.Drawing.Size(0, 57);
            mssqlCheckButton.Name = "mssqlCheckButton";
            mssqlCheckButton.Size = new System.Drawing.Size(149, 57);
            mssqlCheckButton.TabIndex = 19;
            mssqlCheckButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            mssqlCheckButton.Values.Image = Properties.Resources.microsoft_black;
            mssqlCheckButton.Values.Text = " Microsoft SQL";
            mssqlCheckButton.Click += kryptonCheckButton1_Click;
            // 
            // mysqlCheckButton
            // 
            mysqlCheckButton.Location = new System.Drawing.Point(7, 2);
            mysqlCheckButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mysqlCheckButton.MinimumSize = new System.Drawing.Size(0, 57);
            mysqlCheckButton.Name = "mysqlCheckButton";
            mysqlCheckButton.Size = new System.Drawing.Size(149, 57);
            mysqlCheckButton.TabIndex = 18;
            mysqlCheckButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            mysqlCheckButton.Values.Image = Properties.Resources.mysql_black;
            mysqlCheckButton.Values.Text = "MySQL";
            mysqlCheckButton.Click += kryptonCheckButton1_Click;
            // 
            // typeLabel
            // 
            typeLabel.Location = new System.Drawing.Point(6, 3);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(37, 20);
            typeLabel.TabIndex = 17;
            typeLabel.Values.Text = "Type";
            // 
            // hostnameTipLabel
            // 
            hostnameTipLabel.Location = new System.Drawing.Point(6, 224);
            hostnameTipLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            hostnameTipLabel.Name = "hostnameTipLabel";
            hostnameTipLabel.Size = new System.Drawing.Size(393, 14);
            hostnameTipLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            hostnameTipLabel.TabIndex = 15;
            hostnameTipLabel.Values.Text = "This is the server your database is hosted on. Try 'localhost' if your database is hosted locally.";
            // 
            // databaseConnectionNameTipLabel
            // 
            databaseConnectionNameTipLabel.Location = new System.Drawing.Point(6, 151);
            databaseConnectionNameTipLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseConnectionNameTipLabel.Name = "databaseConnectionNameTipLabel";
            databaseConnectionNameTipLabel.Size = new System.Drawing.Size(313, 14);
            databaseConnectionNameTipLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            databaseConnectionNameTipLabel.TabIndex = 14;
            databaseConnectionNameTipLabel.Values.Text = "This specifies only how you want the connection to be displayed in the list.";
            // 
            // databasePasswordTextBox
            // 
            databasePasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            databasePasswordTextBox.Location = new System.Drawing.Point(8, 385);
            databasePasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databasePasswordTextBox.Name = "databasePasswordTextBox";
            databasePasswordTextBox.PasswordChar = '*';
            databasePasswordTextBox.Size = new System.Drawing.Size(475, 23);
            databasePasswordTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new System.Drawing.Point(4, 361);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(62, 20);
            passwordLabel.TabIndex = 13;
            passwordLabel.Values.Text = "Password";
            // 
            // databaseUsernameTextBox
            // 
            databaseUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            databaseUsernameTextBox.Location = new System.Drawing.Point(8, 328);
            databaseUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseUsernameTextBox.Name = "databaseUsernameTextBox";
            databaseUsernameTextBox.Size = new System.Drawing.Size(475, 23);
            databaseUsernameTextBox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new System.Drawing.Point(4, 303);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(65, 20);
            usernameLabel.TabIndex = 11;
            usernameLabel.Values.Text = "Username";
            // 
            // databaseNameTextBox
            // 
            databaseNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            databaseNameTextBox.Location = new System.Drawing.Point(9, 270);
            databaseNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseNameTextBox.Name = "databaseNameTextBox";
            databaseNameTextBox.Size = new System.Drawing.Size(475, 23);
            databaseNameTextBox.TabIndex = 4;
            // 
            // databaseNameLabel
            // 
            databaseNameLabel.Location = new System.Drawing.Point(5, 246);
            databaseNameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseNameLabel.Name = "databaseNameLabel";
            databaseNameLabel.Size = new System.Drawing.Size(97, 20);
            databaseNameLabel.TabIndex = 8;
            databaseNameLabel.Values.Text = "Database Name";
            // 
            // databasePortTextBox
            // 
            databasePortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            databasePortTextBox.Location = new System.Drawing.Point(362, 196);
            databasePortTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databasePortTextBox.Name = "databasePortTextBox";
            databasePortTextBox.Size = new System.Drawing.Size(122, 23);
            databasePortTextBox.TabIndex = 3;
            // 
            // portLabel
            // 
            portLabel.Location = new System.Drawing.Point(357, 172);
            portLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(33, 20);
            portLabel.TabIndex = 6;
            portLabel.Values.Text = "Port";
            // 
            // databaseHostnameTextBox
            // 
            databaseHostnameTextBox.Location = new System.Drawing.Point(9, 196);
            databaseHostnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseHostnameTextBox.Name = "databaseHostnameTextBox";
            databaseHostnameTextBox.Size = new System.Drawing.Size(340, 23);
            databaseHostnameTextBox.TabIndex = 2;
            // 
            // databaseConnectionNameTextBox
            // 
            databaseConnectionNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            databaseConnectionNameTextBox.Location = new System.Drawing.Point(9, 122);
            databaseConnectionNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseConnectionNameTextBox.Name = "databaseConnectionNameTextBox";
            databaseConnectionNameTextBox.Size = new System.Drawing.Size(475, 23);
            databaseConnectionNameTextBox.TabIndex = 0;
            // 
            // databaseConnectionNameLabel
            // 
            databaseConnectionNameLabel.Location = new System.Drawing.Point(5, 98);
            databaseConnectionNameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            databaseConnectionNameLabel.Name = "databaseConnectionNameLabel";
            databaseConnectionNameLabel.Size = new System.Drawing.Size(86, 20);
            databaseConnectionNameLabel.TabIndex = 2;
            databaseConnectionNameLabel.Values.Text = "Display Name";
            // 
            // hostnameLabel
            // 
            hostnameLabel.Location = new System.Drawing.Point(5, 172);
            hostnameLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new System.Drawing.Size(66, 20);
            hostnameLabel.TabIndex = 3;
            hostnameLabel.Values.Text = "Hostname";
            // 
            // testConnectionButton
            // 
            testConnectionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            testConnectionButton.Location = new System.Drawing.Point(255, 20);
            testConnectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            testConnectionButton.MinimumSize = new System.Drawing.Size(0, 29);
            testConnectionButton.Name = "testConnectionButton";
            testConnectionButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            testConnectionButton.Size = new System.Drawing.Size(128, 29);
            testConnectionButton.TabIndex = 7;
            testConnectionButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            testConnectionButton.Values.Text = "Test Connection";
            testConnectionButton.Click += kryptonButton2_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveButton.Location = new System.Drawing.Point(390, 20);
            saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            saveButton.MinimumSize = new System.Drawing.Size(0, 29);
            saveButton.Name = "saveButton";
            saveButton.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            saveButton.Size = new System.Drawing.Size(92, 29);
            saveButton.TabIndex = 8;
            saveButton.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            saveButton.Values.Text = "Save";
            saveButton.Click += kryptonButton1_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(saveButton);
            ButtonPanel.Controls.Add(testConnectionButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 441);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(501, 61);
            ButtonPanel.TabIndex = 8;
            // 
            // databasesPanel
            // 
            databasesPanel.Controls.Add(mysqlCheckButton);
            databasesPanel.Controls.Add(postgresqlCheckButton);
            databasesPanel.Controls.Add(mssqlCheckButton);
            databasesPanel.Location = new System.Drawing.Point(12, 29);
            databasesPanel.Name = "databasesPanel";
            databasesPanel.Size = new System.Drawing.Size(476, 63);
            databasesPanel.TabIndex = 21;
            // 
            // AddDatabaseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(501, 502);
            Controls.Add(ButtonPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "AddDatabaseForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add / Edit Database";
            Load += AddDatabaseForm_Load;
            Resize += AddDatabaseForm_Resize;
            ((System.ComponentModel.ISupportInitialize)mainPanel).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonPanel).EndInit();
            ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databasesPanel).EndInit();
            databasesPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel mainPanel;
        private Krypton.Toolkit.KryptonTextBox databaseHostnameTextBox;
        private Krypton.Toolkit.KryptonTextBox databaseConnectionNameTextBox;
        private Krypton.Toolkit.KryptonButton saveButton;
        private Krypton.Toolkit.KryptonLabel databaseConnectionNameLabel;
        private Krypton.Toolkit.KryptonLabel hostnameLabel;
        private Krypton.Toolkit.KryptonTextBox databaseNameTextBox;
        private Krypton.Toolkit.KryptonLabel databaseNameLabel;
        private Krypton.Toolkit.KryptonTextBox databasePortTextBox;
        private Krypton.Toolkit.KryptonLabel portLabel;
        private Krypton.Toolkit.KryptonButton testConnectionButton;
        private Krypton.Toolkit.KryptonTextBox databaseUsernameTextBox;
        private Krypton.Toolkit.KryptonLabel usernameLabel;
        private Krypton.Toolkit.KryptonTextBox databasePasswordTextBox;
        private Krypton.Toolkit.KryptonLabel passwordLabel;
        private Krypton.Toolkit.KryptonLabel databaseConnectionNameTipLabel;
        private Krypton.Toolkit.KryptonLabel hostnameTipLabel;
        private Krypton.Toolkit.KryptonLabel typeLabel;
        private Krypton.Toolkit.KryptonCheckButton mysqlCheckButton;
        private Krypton.Toolkit.KryptonCheckButton mssqlCheckButton;
        private Krypton.Toolkit.KryptonCheckButton postgresqlCheckButton;
        private Krypton.Toolkit.KryptonPanel ButtonPanel;
        private Krypton.Toolkit.KryptonPanel databasesPanel;
    }
}