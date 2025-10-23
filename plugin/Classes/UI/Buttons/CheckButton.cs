/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI.Buttons
{
    public class CheckButton : Control
    {
        public string Text { get; set; }
        public bool IsChecked { get; set; } = false;

        public CheckButton(string id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
