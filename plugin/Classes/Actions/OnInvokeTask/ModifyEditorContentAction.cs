﻿/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions.OnInvokeTask
{
    public class ModifyEditorContentAction : OnWindowCloseAction
    {
        public int TabIndex { get; set; }
        public string Content { get; set; }

        public ModifyEditorContentAction(int tabIndex, string content)
        {
            TabIndex = tabIndex;
            Content = content;
        }   
    }
}
