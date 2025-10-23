/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using pie.Classes.ConfigurationEntities;

namespace pie.Classes.Configuration.FileBased.Impl
{
    public class Plugin : MultiFileConfigurationEntity
    {
        public object Instance { get; set; }
        public string GetName()
        {
            return (string)Instance.GetType().GetMethod("GetName").Invoke(Instance, null);
        }
    }
}
