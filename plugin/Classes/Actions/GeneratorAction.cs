/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class GeneratorAction : ExitAction
    {
        public string[] Values { get; set; }
        public Func<string[], List<ExitAction>> GeneratorFunction { get; set; }

        public GeneratorAction(string[] values, Func<string[], List<ExitAction>> generatorFunction)
        {
            Values = values;
            GeneratorFunction = generatorFunction;
        }   
    }
}
