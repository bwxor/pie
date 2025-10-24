/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions.OnInvokeTask
{
    public class CreateFileAction : OnWindowCloseAction
    {
        public string Path { get; set; }
        public string Content { get; set; }

        public CreateFileAction(string path, string content)
        {
            Path = path;
            Content = content;
        }
    }
}