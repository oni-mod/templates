using HarmonyLib;

namespace myself.mod.Patches
{
    [HarmonyPatch(typeof(ImmigrantScreen), "OnRejectAll")]
    public class Patches
    {

        [HarmonyPrefix]
        public static void Prefix()
        {
            
        }

        [HarmonyPostfix]
        public static void Postfix()
        {
            
        }

    }
}