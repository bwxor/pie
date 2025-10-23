/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class OpenFileAction : ExitAction
    {
        public string Path { get; set; }
        public OpenFileAction(string path)
        {
            Path = path;
        }
    }
}
