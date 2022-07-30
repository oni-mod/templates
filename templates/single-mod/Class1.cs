using System;
using System.Collections.Generic;
using HarmonyLib;
using KMod;

namespace myself.mod
{
    public class Class1 : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
        }

        public override void OnAllModsLoaded(Harmony harmony, IReadOnlyList<Mod> mods)
        {
            base.OnAllModsLoaded(harmony, mods);
        }
    }
}

