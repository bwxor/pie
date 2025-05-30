﻿/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using pie.Classes.ConfigurationEntities;

namespace pie.Classes
{
    public class SelectedTheme : ConfigurationEntity
    {
        public string Name { get; set; }

        public SelectedTheme(string name)
        {
            Name = name;
        }

        public SelectedTheme()
        {

        }
    }
}
