/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions.OnInvokeTask
{
    public class ChangeLabelTextAction : OnWindowOpenAction
    {
        public string LabelId { get; set; }
        public string NewText { get; set; }
    }
}
