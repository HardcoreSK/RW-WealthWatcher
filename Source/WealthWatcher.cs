using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using Verse;
using RimWorld;
using UnityEngine;

namespace WealthWatcher
{
    internal class WealthWatcherMod : Mod
    {
        public WealthWatcherMod(ModContentPack content) : base(content)
        {
            new Harmony("pirateby.wealthwatcher").PatchAll(Assembly.GetExecutingAssembly());
            Log.Message($"WealthWatcher :: Initialized");
        }
    }
}
