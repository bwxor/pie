/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions.OnInvokeTask;
using System.Collections.Generic;

namespace pie.Classes.Form_IO.Output
{
    public class PluginFormOutput
    {
        public bool ApplyChanges { get; set; }
        public Dictionary<string, string> ControlKeyValues { get; set; }
        public List<OnWindowCloseAction> OnCloseActions { get; set; }
    }
}

