using HarmonyLib;
using Localyssation.Util;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Localyssation.Patches.ReplaceText
{
    internal static partial class RTReplacer
    {
        private static Text cachedStorageHeader;

        [HarmonyPatch(typeof(ItemStorageManager), nameof(ItemStorageManager.Update))]
        [HarmonyPostfix]
        public static void ItemStorageManager_Update_Postfix(ItemStorageManager __instance)
        {
            if (__instance._isOpen)
            {
                if (cachedStorageHeader == null)
                {
                    var header = GameObject.Find("_GameUI_InGame/Canvas_DialogSystem/_dolly_storageBox/_header_backdrop/_header_storeNameText");
                    if (header != null)
                        cachedStorageHeader = header.GetComponent<Text>();
                }

                if (cachedStorageHeader != null)
                    cachedStorageHeader.text = Localyssation.GetString(I18nKeys.Storage.HEADER);
            }
            else
            {
                cachedStorageHeader = null;
            }
        }

        [HarmonyPatch(typeof(ItemStorageManager), nameof(ItemStorageManager.Handle_TabVisibility))]
        [HarmonyPostfix]
        public static void ItemStorageManager_Handle_TabVisibility_Postfix(ItemStorageManager __instance)
        {
            __instance._itemTabHeaderText.text = __instance._itemTabHeaderText.text
                .Replace("Equipment", Localyssation.GetString(KeyUtil.GetForAsset(ItemType.GEAR)))
                .Replace("Consumables", Localyssation.GetString(KeyUtil.GetForAsset(ItemType.CONSUMABLE)))
                .Replace("Trade Items", Localyssation.GetString(KeyUtil.GetForAsset(ItemType.TRADE)));
        }

        [HarmonyPatch(typeof(ItemStorageManager), nameof(ItemStorageManager.Init_InventoryTooltip))]
        [HarmonyPrefix]
        public static bool ItemStorageManager_Init_InventoryTooltip_Prefix(ItemStorageManager __instance, int _tabValue)
        {
            ToolTipManager._current._genericToolTip.Set_TooltipAnchorPos(new Vector2(100f, 0f));
            if (0 > _tabValue || _tabValue > 2)
                return false;

            ItemType tab = (ItemType)(byte)_tabValue;
            ToolTipManager._current.Apply_GenericToolTip(Localyssation.GetString(KeyUtil.GetForAsset(tab)));
            ToolTipManager._current._genericToolTip.Enable_ToolTip();
            return false;
        }
    }
}