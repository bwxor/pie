/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI.ValueContainers
{
    public class TextBox : Control
    {
        public string Text { get; set; }
        public bool ReadOnly { get; set; } = false;

        public TextBox(string id)
        {
            Id = id;
        }

        public TextBox(string id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
