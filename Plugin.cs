﻿using BepInEx;
using BepInEx.Logging;

namespace LethalCompanyModding.Template;

/*
    Here are some basic resources on code style and naming conventions to help
    you in your first CSharp plugin!

    https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
    https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
    https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces
*/

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    public static ManualLogSource Log;

    private void Awake()
    {
        /*
            BepinEx makes you a ManualLogSource for free called "Logger"
            and I created a static value above to hold on to it so other
            parts of your plugin's code can find it by using Plugin.Log

            We assign it here
        */
        Log = Logger;

        // Log our awake here so we can see it in LogOutput.txt file
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} is loaded!");
    }

}