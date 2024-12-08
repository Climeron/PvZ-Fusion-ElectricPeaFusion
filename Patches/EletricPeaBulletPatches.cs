using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace ElectricPeaFusion.Patches
{
    [HarmonyPatch(typeof(EletricPeaBullet))]
    public static class EletricPeaBulletPatches
    {
        [HarmonyPatch(nameof(EletricPeaBullet.Start))]
        [HarmonyPostfix]
        private static void PostStart(EletricPeaBullet __instance) => ChangeBulletParameters(__instance);
        private static void ChangeBulletParameters(EletricPeaBullet __instance)
        {
            __instance.normalSpeed = 1.5f;
            __instance.theBulletDamage = 10;
        }
        [HarmonyPatch(nameof(Bullet.Update))]
        [HarmonyPrefix]
        private static bool PreUpdate(EletricPeaBullet __instance) => UpdateDamageCountdown(__instance);
        private static bool UpdateDamageCountdown(EletricPeaBullet __instance)
        {
            __instance.damageCountDown = __instance.damageCountDown < Time.deltaTime ? 0 : __instance.damageCountDown - Time.deltaTime;
            if (__instance.damageCountDown == 0)
            {
                __instance.damageCountDown = 0.2f;
                __instance.DamageZombies();
            }
            return false;
        }
    }
}
