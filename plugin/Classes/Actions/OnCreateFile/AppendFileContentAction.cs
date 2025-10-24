/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions.Window
{
    public class AppendFileContentAction : OnCreateFileAction
    {
        public string NewContent { get; set; }
        public bool OnBeginning { get; set; }

        public AppendFileContentAction(string newContent)
        {
            NewContent = newContent;
            OnBeginning = false;
        }

        public AppendFileContentAction(string newContent, bool onBeginning)
        {
            NewContent = newContent;
            OnBeginning = onBeginning;
        }
    }
}
