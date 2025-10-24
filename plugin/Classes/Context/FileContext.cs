/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Context
{
    public class FileContext
    {
        public bool IsFileOpened { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
    }
}
