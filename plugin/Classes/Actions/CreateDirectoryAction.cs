/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class CreateDirectoryAction : ExitAction
    {
        public string DirectoryName { get; set; }
        public CreateDirectoryAction(string directoryName)
        {
            DirectoryName = directoryName;
        }   
    }
}
