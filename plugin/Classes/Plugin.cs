/* SPDX-FileCopyrightText: 2023-2025 Mario-Mihai Mateas <mateasmario@aol.com> */
/* SPDX-License-Identifier: GPL-3.0-or-later */

using plugin.Classes.UI.Containers;

namespace plugin.Classes;

public interface Plugin
{
    string DisplayName();
    List<Window> GetWindows();
}
