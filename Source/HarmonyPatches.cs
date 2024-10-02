using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;
using Verse.AI.Group;

namespace WealthWatcher
{

    public static class HarmonyPatches
    {
        [HarmonyPatch(typeof(RimWorld.PlaySettings))]
        [HarmonyPatch(nameof(RimWorld.PlaySettings.DoPlaySettingsGlobalControls))]
        public static class Patch_DoPlaySettingsGlobalControls
        {
            public static void Postfix(ref WidgetRow row, bool worldView)
            {
                if (!worldView)
                {
                    if (Find.CurrentMap != null && row.ButtonIcon(Util.WealthIcon, "WealthWatcherTip".Translate(), null, null, null, true, -1f))
                    {
                        Find.WindowStack.Add(new MainWindow());
                    }
                }
            }
        }

    }

}
