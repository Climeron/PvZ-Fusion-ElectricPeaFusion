using MelonLoader;
using ClimeronToolsForPvZ.Extensions;
using Il2Cpp;
using UnityEngine;

namespace ElectricPeaFusion
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            DefineElectricPeaPrefabs();
            RepairMixData();
            EnableElectricPeaHybrid();
        }
        private void DefineElectricPeaPrefabs()
        {
            GameAPP.plantPrefab[257] = Resources.Load<GameObject>("Plants/Peashooter/Electricpea/Electricpeaprefab");
            GameAPP.prePlantPrefab[257] = Resources.Load<GameObject>("Plants/Peashooter/Electricpea/Electricpeapreview");
        }
        private void RepairMixData() =>
            MixData.data = Il2CppSystem.Array.CreateInstance(typeof(int).ToIl2CppType(), 2048, 2048);
        private void EnableElectricPeaHybrid()
        {
            Il2CppSystem.Array array = MixData.data.Cast<Il2CppSystem.Array>();
            array.SetValue(257, 0, 1100);
            array.SetValue(257, 1100, 0);
        }
    }
}
