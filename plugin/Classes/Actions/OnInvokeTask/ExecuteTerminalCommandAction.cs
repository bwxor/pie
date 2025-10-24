/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions.OnInvokeTask
{
    public class ExecuteTerminalCommandAction : OnWindowCloseAction
    {
        public string Command { get; set; }

        public ExecuteTerminalCommandAction(string command)
        {
            Command = command;
        }
    }
}