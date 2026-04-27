using HarmonyLib;
using Localyssation.Util;
using UnityEngine;
using UnityEngine.UI;

namespace Localyssation.Patches.ReplaceText
{

    internal static partial class RTReplacer
    {
        [HarmonyPatch(typeof(ShopkeepManager), nameof(ShopkeepManager.Handle_ShopkeepUIBehavior))]
        [HarmonyPostfix]
        public static void ShopkeepManager_Handle_ShopkeepUIBehavior_Postfix(ShopkeepManager __instance)
        {
            if (__instance._scriptShopkeep != null)
            {
                __instance._shopkeepHeaderText.text = "- " + Localyssation.GetString(KeyUtil.GetForAsset(__instance._scriptShopkeep) + "_SHOP_NAME") + " -";
                __instance._shopkeepTabHeaderText.text = Localyssation.GetString(KeyUtil.GetForAsset(__instance._currentShopTab));

                __instance._rerollGambleButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_REROLL);

                __instance._sellQuantityOneButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_SELL_SINGLE);
                __instance._sellQuantityButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_SELL_QUANTITY);
                __instance._cancelSellPromptButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_CANCEL_SELL);

                __instance._purchaseButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_PURCHASE_SINGLE);
                __instance._purchaseQuantityButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_PURCHASE_QUANTITY);
                __instance._cancelPromptButton.GetComponentInChildren<Text>().text = Localyssation.GetString(I18nKeys.Shop.BUTTON_CANCEL_PURCHASE);
            }
        }


        [HarmonyPatch(typeof(ShopkeepManager), nameof(ShopkeepManager.Init_ShopTooltip))]
        [HarmonyPrefix]
        public static bool ShopkeepManager_Init_ShopTooltip_Prefix(ShopkeepManager __instance, int _tabValue)
        {
            ToolTipManager._current._genericToolTip.Set_TooltipAnchorPos(new Vector2(100f, 0f));
            if (0 > _tabValue || _tabValue > 3)
                return false;
            ShopTab tab = (ShopTab)(byte)_tabValue;
            ToolTipManager._current.Apply_GenericToolTip(Localyssation.GetString(KeyUtil.GetForAsset(tab)));
            ToolTipManager._current._genericToolTip.Enable_ToolTip();
            return false;
        }
    }
}
