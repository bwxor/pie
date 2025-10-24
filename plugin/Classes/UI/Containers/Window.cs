/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions.OnInvokeTask;

namespace plugin.Classes.UI.Containers
{
    public class Window : Control
    {
        public string Title { get; set; }
        public List<Control> Controls { get; set; } = new List<Control>();
        public List<OnWindowOpenAction> OnOpen { get; set; }
        public List<OnWindowCloseAction> OnClose { get; set; }

        public Window(string title)
        {
            Title = title;
        }
    }
}
