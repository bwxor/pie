/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.Actions.Window;
using plugin.Classes.Context;
using plugin.Classes.UI.Containers;

namespace plugin.Classes;

public interface Plugin
{
    PluginInfo OnLoad();
    Window OnInvokeTask(string taskName, PluginContext context);
    List<OnCreateFileAction> OnCreateFile(string fullFilePath, PluginContext context);
    List<OnOpenDirectoryAction> OnOpenDirectory(string directoryPath, PluginContext context);

    // ToDo: OnEditorChange, OnFileOpen, etc.
}
