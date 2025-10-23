/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.UI.ValueContainers
{
    public class ComboBox : Control
    {
        public List<string> Items { get; set; } = new List<string>();

        public ComboBox(string id, List<string> items)
        {
            Id = id;
            Items = items;
        }
    }
}
