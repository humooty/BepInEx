﻿using BepInEx.Configuration;
using BepInEx.Logging;

namespace BepInEx.Contract;

internal interface IPlugin
{
    /// <summary>
    /// Information about this plugin as it was loaded.
    /// </summary>
    PluginInfo Info { get; }

    /// <summary>
    /// Logger instance tied to this plugin.
    /// </summary>
    ManualLogSource Log { get; }

    /// <summary>
    /// Default config file tied to this plugin. The config file will not be created until 
    /// any settings are added and changed, or <see cref="ConfigFile.Save"/> is called.
    /// </summary>
    ConfigFile Config { get; }
}
