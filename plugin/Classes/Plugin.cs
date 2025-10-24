/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Context;
using plugin.Classes.UI.Containers;

namespace plugin.Classes;

public interface Plugin
{
    PluginInfo OnLoad();
    Window OnInvokeTask(string taskName, PluginContext context);

    // ToDo: onEditorChange, onFileCreate, onFileOpen, etc.
}
