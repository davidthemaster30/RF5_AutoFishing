using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace RF5_AutoFishing;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess(GAME_PROCESS)]
public class Main : BasePlugin
{

    public static new ManualLogSource Log;
    private const string GAME_PROCESS = "Rune Factory 5.exe";

    public override void Load()
    {
        Log = base.Log;
        new Harmony(MyPluginInfo.PLUGIN_GUID).PatchAll();
    }
}
