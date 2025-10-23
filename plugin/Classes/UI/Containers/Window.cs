/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions;

namespace plugin.Classes.UI.Containers
{
    public class Window : Control
    {
        public string Title { get; set; }
        public List<Control> Controls { get; set; } = new List<Control>();
        public List<UIAction> OnOpen { get; set; }
        public List<ExitAction> OnClose { get; set; }
        public int Size { get; set; }

        public Window(string title)
        {
            Title = title;
        }

        public Window(string title, int size)
        {
            Title = title;
            Size = size;
        }
    }
}
