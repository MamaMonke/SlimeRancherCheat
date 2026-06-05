using MonomiPark.SlimeRancher.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SlimeRancherCheat
{
    internal class Mods
    {
        static public void AddMoney()
        {
            SRSingleton<SceneContext>.Instance.PlayerState.AddCurrency(5000);
        }

    }
}
