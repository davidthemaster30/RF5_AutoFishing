using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using BepInEx.IL2CPP;
using BepInEx.Logging;

namespace RF5_AutoFishing
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess(GAME_PROCESS)]
    public class Main : BasePlugin
    {
        #region PluginInfo
        private const string GUID = "A8262A85-88AF-873E-E27A-DD44C5CE423A";
        private const string NAME = "RF5_AutoFishing";
        private const string VERSION = "1.0.1";
        private const string GAME_PROCESS = "Rune Factory 5.exe";
        #endregion

        public static new ManualLogSource Log;

        public override void Load()
        {
            Log = base.Log;
            new Harmony(GUID).PatchAll();
        }
    }
}
