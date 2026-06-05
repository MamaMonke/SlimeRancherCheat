using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SlimeRancherCheat.Mods;
using static SlimeRancherCheat.Slimer;
using UnityEngine.UI;
using UnityEngine;
using BepInEx;

namespace SlimeRancherCheat
{
    [BepInPlugin("MamaMonkeGUI", "MamaMonke", "0.0.1")]
    public class UIMain : BaseUnityPlugin
    {
        void OnGUI()
        {
            GUI.color = Color.magenta;
            GUI.Box(new Rect(10, 10, 400, 560), "Mamamonke GUI");

            //mid top
            if (GUI.Button(new Rect(75, 40, 260, 30), "Add 5K Money"))
            {
                Mods.AddMoney();
            }
            //left
            if (GUI.Button(new Rect(20, 80, 120, 30), "Spawn PinkSlime"))
            {
                Slimer.SpawnPink();
            }
            //right
            if (GUI.Button(new Rect(150, 80, 120, 30), "Spawn TabbySlime"))
            {
                Slimer.SpawnTabby();
            }
            //left
            if (GUI.Button(new Rect(20, 120, 120, 30), "Spawn PhosphorSlime"))
            {
                Slimer.SpawnPhosphor();
            }
            //right
            if (GUI.Button(new Rect(150, 120, 120, 30), "Spawn GoldSlime"))
            {
                Slimer.SpawnGoldSlime();
            }
            //mid bottom
            if (GUI.Button(new Rect(75, 160, 260, 30), "Spawn All Types"))
            {
                Slimer.SpawnAllType();
            }
        }
    }
}
