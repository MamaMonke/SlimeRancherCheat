using MonomiPark.SlimeRancher.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SlimeRancherCheat
{
    internal class Slimer
    {
        public static void SpawnPink()
        {
            var prefab = SRSingleton<GameContext>.Instance.LookupDirector.GetPrefab(Identifiable.Id.PINK_SLIME);
            var pos = new Vector3(82f, 14f, -110f);
            SRBehaviour.InstantiateActor(prefab, RegionRegistry.RegionSetId.HOME, pos, Quaternion.identity);
        }
        public static void SpawnTabby()
        {
            var prefab = SRSingleton<GameContext>.Instance.LookupDirector.GetPrefab(Identifiable.Id.TABBY_SLIME);
            var pos = new Vector3(82f, 14f, -110f);
            SRBehaviour.InstantiateActor(prefab, RegionRegistry.RegionSetId.HOME, pos, Quaternion.identity);
        }
        public static void SpawnPhosphor()
        {
            var prefab = SRSingleton<GameContext>.Instance.LookupDirector.GetPrefab(Identifiable.Id.PHOSPHOR_SLIME);
            var pos = new Vector3(82f, 14f, -110f);
            SRBehaviour.InstantiateActor(prefab, RegionRegistry.RegionSetId.HOME, pos, Quaternion.identity);
        }
        public static void SpawnGoldSlime()
        {
            var prefab = SRSingleton<GameContext>.Instance.LookupDirector.GetPrefab(Identifiable.Id.GOLD_SLIME);
            var pos = new Vector3(82f, 14f, -110f);
            SRBehaviour.InstantiateActor(prefab, RegionRegistry.RegionSetId.HOME, pos, Quaternion.identity);
        }

        public static void SpawnAllType()
        {
            foreach (var id in Identifiable.SLIME_CLASS)
            {
                var prefab = SRSingleton<GameContext>.Instance.LookupDirector.GetPrefab(id);
                if (prefab != null)
                    SRBehaviour.InstantiateActor(prefab, RegionRegistry.RegionSetId.HOME, new Vector3(82f, 14f, -110f), Quaternion.identity);
            }
        }
    }
}
