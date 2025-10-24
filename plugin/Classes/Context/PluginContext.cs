/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Context
{
    public class PluginContext
    {
        public string AppVersion { get; set; }
        public List<FileContext> OpenedTabs { get; set; }
        public string OpenedDirectory { get; set; }
        public Dictionary<string, string> Custom { get; set; } = new Dictionary<string, string>();
    }
}
