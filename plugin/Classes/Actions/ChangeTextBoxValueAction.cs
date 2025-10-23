/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class ChangeTextBoxValueAction : UIAction
    {
        public string TextBoxId { get; set; }
        public string NewValue { get; set; }
    }
}
