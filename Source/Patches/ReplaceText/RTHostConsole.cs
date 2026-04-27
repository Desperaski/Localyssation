using HarmonyLib;
using Localyssation.Util;
using UnityEngine.UI;

namespace Localyssation.Patches.ReplaceText
{
    internal static partial class RTReplacer
    {
        [HarmonyPatch(typeof(HostConsole), nameof(HostConsole.Init_NetworkStatusMessage))]
        [HarmonyPrefix]
        public static void HostConsole_Init_NetworkStatusMessage_Prefix(HostConsole __instance, ref string _msg)
        {
            _msg = _msg
                .Replace("Character file saved...", Localyssation.GetString(I18nKeys.HostConsole.CHARACTER_FILE_SAVED))
                .Replace("Settings Profile Saved...", Localyssation.GetString(I18nKeys.HostConsole.SETTINGS_PROFILE_SAVED));
        }
    }
}