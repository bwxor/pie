/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions;

namespace plugin.Classes.UI.Buttons
{
    public class Button : Control
    {
        public string Text { get; set; }
        public List<UIAction> OnClick { get; set; }
    }
}
