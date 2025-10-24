/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions.OnInvokeTask;
using plugin.Classes.Actions.Window;

namespace plugin.Classes.Actions
{
    public class StoreInContextAction : OnWindowCloseAction, OnWindowOpenAction, OnCreateFileAction, OnOpenDirectoryAction
    {
        public string Key{ get; set; }
        public string Value { get; set; }
        public StoreInContextAction(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
