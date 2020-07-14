using Harmony;

namespace NoEatingNoise
{
    [HarmonyPatch(typeof(TechSoundData), nameof(TechSoundData.GetUseSound))]
    internal class NoEatingPatch
    {
        [HarmonyPrefix]
        internal static void Prefix(ref TechData.SoundType type)
        {
            if (IsFoodSoundType(type))
                type = (TechData.SoundType)int.MaxValue;
        }

        private static bool IsFoodSoundType(TechData.SoundType soundType)
        {
            return soundType == TechData.SoundType.Meat
                   || soundType == TechData.SoundType.Food
                   || soundType == TechData.SoundType.Liquid;
        }
    }
}
