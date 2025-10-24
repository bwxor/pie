/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using pie.Classes;
using pie.Classes.Form_IO.Output;
using pie.Classes.PluginSupport;
using pie.Services;

/** 
 * Krypton Suite's Standard Toolkit was often used in order to design the .NET controls found inside this application.
 * 
 * Copyright (c) 2017 - 2022, Krypton Suite
*/
using Krypton.Toolkit;
using System.Drawing;
using plugin.Classes.UI.Containers;

namespace pie.Forms.Other
{
    public partial class PluginForm : KryptonForm
    {
        private List<Control> dynamicControls = new List<Control>();

        private ThemingService themeService = new ThemingService();
        private PluginPlaceholderReplaceService pluginPlaceholderReplace = new PluginPlaceholderReplaceService();

        public PluginFormInput Input { get; set; }
        public PluginFormOutput Output { get; set; }

        public PluginForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Output = new PluginFormOutput();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {
            Window window = Input.Plugin.InvokeTask(Input.TaskName, Input.PluginContext);

            int height = 150;

            foreach(plugin.Classes.UI.Control c in window.Controls)
            {
                if (c is plugin.Classes.UI.Decoration.Label)
                {
                    height += 20;
                }
                else if (c is plugin.Classes.UI.Decoration.SpaceDelimiter)
                {
                    height += 10;
                }
                else if (c is plugin.Classes.UI.Buttons.CheckButton)
                {
                    height += 20;
                }
                else if (c is plugin.Classes.UI.ValueContainers.TextBox || c is plugin.Classes.UI.ValueContainers.ComboBox)
                {
                    height += 20;
                }
                else
                {
                    height += 20;
                }
            }

            this.Size = new Size(this.Width, height);


            themeService.SetPaletteToObjects(this, Input.Palette);

            if (Input.EditorProperties.Glass)
            {
                this.Opacity = 0.875;
            }

            this.Text = window.Title;
            foreach (var control in window.Controls)
            {
                Control controlToAdd = null;

                if (control is plugin.Classes.UI.Decoration.Label)
                {
                    plugin.Classes.UI.Decoration.Label b = (plugin.Classes.UI.Decoration.Label)control;
                    controlToAdd = new KryptonLabel
                    {
                        Text = b.Text,
                        Dock = DockStyle.Fill,
                        Margin = Padding.Empty,
                        Padding = Padding.Empty
                    };
                    controlToAdd.Tag = b;

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        dynamicControls.Add(controlToAdd);
                    }
                }
                else if (control is plugin.Classes.UI.Buttons.Button)
                {
                    plugin.Classes.UI.Buttons.Button b = (plugin.Classes.UI.Buttons.Button)control;
                    controlToAdd = new KryptonButton { Text = b.Text };
                    controlToAdd.Tag = b;

                    if (b.OnClick != null)
                    {
                        controlToAdd.Click += ButtonClick;
                    }

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        dynamicControls.Add(controlToAdd);
                    }
                }
                else if (control is plugin.Classes.UI.ValueContainers.TextBox)
                {
                    plugin.Classes.UI.ValueContainers.TextBox tb = (plugin.Classes.UI.ValueContainers.TextBox)control;
                    controlToAdd = new KryptonTextBox { Text = tb.Text, Width = 200 };
                    controlToAdd.Tag = tb;
                    controlToAdd.Dock = DockStyle.Fill;

                    if (tb.ReadOnly)
                    {
                        (controlToAdd as KryptonTextBox).ReadOnly = true;
                    }

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        dynamicControls.Add(controlToAdd);
                    }
                }
                else if (control is plugin.Classes.UI.Buttons.CheckButton)
                {
                    plugin.Classes.UI.Buttons.CheckButton b = (plugin.Classes.UI.Buttons.CheckButton)control;
                    controlToAdd = new KryptonCheckBox { Text = b.Text };
                    controlToAdd.Tag = b;
                    (controlToAdd as KryptonCheckBox).StateNormal.ShortText.Color1 = Input.ActiveTheme.Fore;
                    (controlToAdd as KryptonCheckBox).StateNormal.ShortText.Color2 = Input.ActiveTheme.Fore;
                    (controlToAdd as KryptonCheckBox).PaletteMode = PaletteMode.ProfessionalOffice2003;

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        dynamicControls.Add(controlToAdd);
                    }
                }
                else if (control is plugin.Classes.UI.ValueContainers.ComboBox)
                {
                    plugin.Classes.UI.ValueContainers.ComboBox b = (plugin.Classes.UI.ValueContainers.ComboBox)control;
                    controlToAdd = new KryptonComboBox();

                    KryptonComboBox comboBox = controlToAdd as KryptonComboBox;

                    foreach (var item in b.Items)
                    {
                        comboBox.Items.Add(item);
                    }

                    comboBox.SelectedIndex = b.DefaultIndex;

                    controlToAdd.Tag = b;

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        controlToAdd.Dock = DockStyle.Top;
                        dynamicControls.Add(controlToAdd);
                    }
                }
                else if (control is plugin.Classes.UI.Composite.FileBrowser)
                {
                    plugin.Classes.UI.Composite.FileBrowser fileBrowserControl = (plugin.Classes.UI.Composite.FileBrowser)control;
                    controlToAdd = new KryptonSplitContainer();
                    var container = controlToAdd as KryptonSplitContainer;
                    container.Dock = DockStyle.Fill;

                    KryptonTextBox kryptonTextBox = new KryptonTextBox();
                    kryptonTextBox.ReadOnly = true;
                    kryptonTextBox.Tag = fileBrowserControl;

                    if (fileBrowserControl.Value != null)
                    {
                        kryptonTextBox.Text = fileBrowserControl.Value;
                    }

                    container.Panel1.Controls.Add(kryptonTextBox);
                    kryptonTextBox.Dock = DockStyle.Fill;

                    KryptonButton kryptonButton = new KryptonButton() { Text = "Browse..." };
                    kryptonButton.Tag = new FileBrowserPluginSupport(kryptonTextBox, fileBrowserControl.Filter);
                    kryptonButton.Click += FileBrowserButtonClick;

                    container.Panel2.Padding = new Padding(5, 0, 0, 0);

                    container.Panel2.Controls.Add(kryptonButton);
                    kryptonButton.Dock = DockStyle.Left;

                    container.SplitterDistance = (int)(container.Width);
                    container.SplitterWidth = 0;
                    container.Height = kryptonTextBox.Height;

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        dynamicControls.Add(kryptonTextBox);
                    }
                }
                else if (control is plugin.Classes.UI.Composite.FolderBrowser)
                {
                    plugin.Classes.UI.Composite.FolderBrowser folderBrowserControl = (plugin.Classes.UI.Composite.FolderBrowser)control;
                    controlToAdd = new KryptonSplitContainer();
                    var container = controlToAdd as KryptonSplitContainer;
                    container.Dock = DockStyle.Fill;

                    KryptonTextBox kryptonTextBox = new KryptonTextBox();
                    kryptonTextBox.ReadOnly = true;
                    kryptonTextBox.Tag = folderBrowserControl;
                    if (folderBrowserControl.Value != null)

                    {
                        kryptonTextBox.Text = folderBrowserControl.Value;
                    }

                    container.Panel1.Controls.Add(kryptonTextBox);
                    kryptonTextBox.Dock = DockStyle.Fill;

                    container.Panel2.Padding = new Padding(5, 0, 0, 0);

                    KryptonButton kryptonButton = new KryptonButton() { Text = "Browse..." };
                    kryptonButton.Tag = kryptonTextBox;
                    kryptonButton.Click += FolderBrowserClick;
                    container.Panel2.Controls.Add(kryptonButton);
                    kryptonButton.Dock = DockStyle.Left;

                    container.SplitterDistance = (int)(container.Width);
                    container.SplitterWidth = 0;
                    container.Height = kryptonTextBox.Height;

                    if (control != null)
                    {
                        TableLayoutPanel.RowCount += 1;
                        TableLayoutPanel.Controls.Add(controlToAdd, 0, TableLayoutPanel.RowCount - 1);
                        dynamicControls.Add(kryptonTextBox);
                    }
                }
                else if (control is plugin.Classes.UI.Decoration.SpaceDelimiter)
                {
                    KryptonLabel label = new KryptonLabel();
                    label.Text = "";
                    TableLayoutPanel.RowCount += 1;
                    TableLayoutPanel.Controls.Add(label, 0, TableLayoutPanel.RowCount - 1);
                }
            }

            Output.OnCloseActions = window.OnClose;
            themeService.SetPaletteToObjects(this, Input.Palette);
            ProcessUIActions(window.OnOpen);
        }

        private void FolderBrowserClick(object sender, EventArgs e)
        {
            if (sender is KryptonButton == false)
            {
                return;
            }

            var kryptonTextBox = ((KryptonButton)sender).Tag as KryptonTextBox;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void FileBrowserButtonClick(object sender, EventArgs e)
        {
            if (sender is KryptonButton == false)
            {
                return;
            }

            var fileBrowserSupport = ((KryptonButton)sender).Tag as FileBrowserPluginSupport;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileBrowserSupport.Filter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileBrowserSupport.TextBox.Text = openFileDialog.FileName;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is KryptonButton  == false)
            {
                return;
            }

            plugin.Classes.UI.Buttons.Button b = ((KryptonButton)sender).Tag as plugin.Classes.UI.Buttons.Button;
            ProcessUIActions(b.OnClick);
        }

        private void ProcessUIActions(List<plugin.Classes.Actions.OnInvokeTask.OnWindowOpenAction> actions)
        {
            if (actions == null)
            {
                return;
            }

            foreach (var action in actions)
            {
                if (action is plugin.Classes.Actions.OnInvokeTask.ChangeLabelTextAction)
                {
                    var a = action as plugin.Classes.Actions.OnInvokeTask.ChangeLabelTextAction;
                    var foundControl = FindControlById(a.LabelId);

                    if (foundControl != null)
                    {
                        KryptonLabel targetLabel = foundControl as KryptonLabel;
                        targetLabel.Text = a.NewText;
                    }
                }
                else if (action is plugin.Classes.Actions.OnInvokeTask.ShowNotificationAction)
                {
                    var a = action as plugin.Classes.Actions.OnInvokeTask.ShowNotificationAction;
                    ShowNotification(a.Message);
                }
            }
        }

        private System.Windows.Forms.Control FindControlById(string id)
        {
            foreach (var control in dynamicControls)
            {
                if (control.Tag != null && control.Tag is plugin.Classes.UI.Control)
                {
                    plugin.Classes.UI.Control c = control.Tag as plugin.Classes.UI.Control;
                    if (c.Id == id)
                    {
                        return control;
                    }
                }
            }

            return null;
        }

        public void ShowNotification(string text)
        {
            NotificationOKForm notificationOkForm = new NotificationOKForm();

            NotificationFormInput notificationFormInput = new NotificationFormInput();
            notificationFormInput.EditorProperties = new EditorProperties();
            notificationFormInput.Palette = Input.Palette;
            notificationFormInput.NotificationText = text;

            notificationOkForm.Input = notificationFormInput;

            notificationOkForm.ShowDialog();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Output.ApplyChanges = true;

            Output.ControlKeyValues = new Dictionary<string, string>();

            foreach (Control c in dynamicControls)
            {
                if (c.Tag is plugin.Classes.UI.ValueContainers.TextBox)
                {
                    Output.ControlKeyValues.Add((c.Tag as plugin.Classes.UI.ValueContainers.TextBox).Id, (c as KryptonTextBox).Text ?? "");
                }
                else if (c.Tag is plugin.Classes.UI.Buttons.CheckButton)
                {
                    Output.ControlKeyValues.Add((c.Tag as plugin.Classes.UI.Buttons.CheckButton).Id, (c as KryptonCheckBox).Checked.ToString().ToLower());
                }
                else if (c.Tag is plugin.Classes.UI.ValueContainers.ComboBox)
                {
                    Output.ControlKeyValues.Add((c.Tag as plugin.Classes.UI.ValueContainers.ComboBox).Id, (c as KryptonComboBox).Text ?? "");
                }
                else if (c.Tag is plugin.Classes.UI.Composite.FileBrowser)
                {
                    Output.ControlKeyValues.Add((c.Tag as plugin.Classes.UI.Composite.FileBrowser).Id, (c as KryptonTextBox).Text ?? "");
                }
                else if (c.Tag is plugin.Classes.UI.Composite.FolderBrowser)
                {
                    Output.ControlKeyValues.Add((c.Tag as plugin.Classes.UI.Composite.FolderBrowser).Id, (c as KryptonTextBox).Text ?? "");
                }

                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
