/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI
{
    public class TextBox : Control
    {
        public string Text { get; set; }
        public bool ReadOnly { get; set; } = false;
    }
}
