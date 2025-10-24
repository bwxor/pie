/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI.Composite
{
    public class FolderBrowser : Control
    {
        public string Value { get; set; }

        public FolderBrowser(string id)
        {
            Id = id;
        }

        public FolderBrowser(string id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
