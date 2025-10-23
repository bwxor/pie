/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class StoreInContextAction : ExitAction
    {
        public string Key{ get; set; }
        public string Value { get; set; }
        public StoreInContextAction(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
