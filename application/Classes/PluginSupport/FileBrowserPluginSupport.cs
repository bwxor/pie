/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using Krypton.Toolkit;

namespace pie.Classes.PluginSupport
{
    public class FileBrowserPluginSupport
    {
        public KryptonTextBox TextBox { get; set; }
        public string Filter { get; set; }

        public FileBrowserPluginSupport(KryptonTextBox textBox, string filter)
        {
            TextBox = textBox;
            Filter = filter;
        }
    }
}
