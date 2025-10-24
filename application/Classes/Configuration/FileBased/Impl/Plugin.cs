/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using pie.Classes.ConfigurationEntities;
using plugin.Classes.Context;
using plugin.Classes.UI.Containers;
using System.Collections.Generic;

namespace pie.Classes.Configuration.FileBased.Impl
{
    public class Plugin : MultiFileConfigurationEntity
    {
        public object Instance { get; set; }
        public List<string> TaskNames { get; set; }
        public Window InvokeTask(string taskName, PluginContext pluginContext)
        {
            return (Window)Instance.GetType().GetMethod("OnInvokeTask").Invoke(Instance, new object[] { taskName, pluginContext });
        }
    }
}
