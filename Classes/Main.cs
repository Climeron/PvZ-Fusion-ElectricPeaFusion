using MelonLoader;
using ClimeronToolsForPvZ.Extensions;
using Il2Cpp;
using UnityEngine;
using System;

namespace ElectricPeaFusion
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            DefineElectricPeaPrefabs();
            DefineElectricPeaData();
            RepairMixData();
            EnableElectricPeaHybrid();
        }
        public override void OnLateInitializeMelon()
        {
            base.OnLateInitializeMelon();
        }
        private void DefineElectricPeaPrefabs()
        {
            GameAPP.plantPrefab[257] = Resources.Load<GameObject>("Plants/Peashooter/Electricpea/Electricpeaprefab");
            GameAPP.prePlantPrefab[257] = Resources.Load<GameObject>("Plants/Peashooter/Electricpea/Electricpeapreview");
        }
        private void DefineElectricPeaData()
        {
            PlantDataLoader.PlantData_ data = new();
            data.field_Public_Int32_0 = 257;
            data.field_Public_Single_0 = 3;
            data.field_Public_Single_1 = 0;
            data.attackDamage = 40;
            data.field_Public_Int32_1 = 300;
            data.field_Public_Single_2 = 7.5f;
            data.field_Public_Int32_2 = 300;
            PlantDataLoader.plantData[data.field_Public_Int32_0] = data;
        }
        private void RepairMixData()
        {
            try
            {
                if (MixData.data != null)
                    $"Property '{nameof(MixData.data)}' already initialized.".Print();
            }
            catch (Exception)
            {
                MixData.data = Il2CppSystem.Array.CreateInstance(typeof(int).ToIl2CppType(), 2048, 2048);
                $"Property '{nameof(MixData.data)}' initialized.".Print();
            }
        }
        private void EnableElectricPeaHybrid()
        {
            Il2CppSystem.Array array = MixData.data.Cast<Il2CppSystem.Array>();
            array.SetValue(257, 0, 1100);
            array.SetValue(257, 1100, 0);
        }
    }
}
