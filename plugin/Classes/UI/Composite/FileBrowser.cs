/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI.Composite
{
    public class FileBrowser : Control
    {
        public string Filter { get; set; }

        public FileBrowser(String id, String filter)
        {
            Id = id;
            Filter = filter;
        }
    }
}
