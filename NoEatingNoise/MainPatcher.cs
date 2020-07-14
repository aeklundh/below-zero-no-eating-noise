using Harmony;
using System.Reflection;

namespace NoEatingNoise
{
    public class MainPatcher
    {
        public static void Patch()
        {
            var harmony = HarmonyInstance.Create("com.aeklundh.subnauticabelowzero.noeatingnoise.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
