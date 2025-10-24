/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI.Composite
{
    public class FileBrowser : Control
    {
        public string Filter { get; set; }
        public string Value { get; set; }

        public FileBrowser(string id, string filter)
        {
            Id = id;
            Filter = filter;
        }

        public FileBrowser(string id, string filter, string value)
        {
            Id = id;
            Filter = filter;
            Value = value;
        }
    }
}
