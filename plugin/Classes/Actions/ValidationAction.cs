/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

namespace plugin.Classes.Actions
{
    public class ValidationAction : ExitAction
    {
        public string VariableId { get; set; }
        public Func<string, bool> ValidationFunction { get; set; }
        public string ErrorMessage { get; set; }

        public ValidationAction(string variableId, Func<string, bool> validationFunction, string errorMessage)
        {
            VariableId = variableId;
            ValidationFunction = validationFunction;
            ErrorMessage = errorMessage;
        }
    }
}
