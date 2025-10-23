/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

/** 
 * Krypton Suite's Standard Toolkit was often used in order to design the .NET controls found inside this application.
 * 
 * Copyright (c) 2017 - 2022, Krypton Suite
*/
using Krypton.Toolkit;
using plugin.Classes;
using plugin.Classes.UI.Containers;

namespace pie.Classes
{
    public class PluginFormInput
    {
        public KryptonCustomPaletteBase Palette { get; set; }
        public EditorProperties EditorProperties { get; set; }
        public ThemeInfo ActiveTheme { get; set; }
        public Window PluginWindow { get; set; }
        public PluginContextSupport PluginContext { get; set; }
    }
}
