/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions.OnInvokeTask;
using plugin.Classes.Actions.Window;

namespace plugin.Classes.Actions
{
    public class OpenFileAction : OnWindowCloseAction, OnCreateFileAction
    {
        public string Path { get; set; }
        public OpenFileAction(string path)
        {
            Path = path;
        }
    }
}
