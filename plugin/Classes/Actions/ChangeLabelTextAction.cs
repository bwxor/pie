/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class ChangeLabelTextAction : UIAction
    {
        public string LabelId { get; set; }
        public string NewText { get; set; }
    }
}
