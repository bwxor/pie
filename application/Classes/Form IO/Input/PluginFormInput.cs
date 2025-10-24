/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

/** 
 * Krypton Suite's Standard Toolkit was often used in order to design the .NET controls found inside this application.
 * 
 * Copyright (c) 2017 - 2022, Krypton Suite
*/
using Krypton.Toolkit;
using plugin.Classes.Context;
using plugin.Classes.UI.Containers;

namespace pie.Classes
{
    public class PluginFormInput
    {
        public KryptonCustomPaletteBase Palette { get; set; }
        public EditorProperties EditorProperties { get; set; }
        public ThemeInfo ActiveTheme { get; set; }
        public PluginContext PluginContext { get; set; }
        public pie.Classes.Configuration.FileBased.Impl.Plugin Plugin { get; set; }
        public string TaskName { get; set; }
    }
}
