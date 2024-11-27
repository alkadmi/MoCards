using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnboundLib;
using HarmonyLib;
using System.Numerics;
using MoCards.Patches;

namespace MoCards.Effects
{
    internal class NoSelfDamageBounceEffect : DealtDamageEffect
    {
        
        public override void DealtDamage(UnityEngine.Vector2 damage, bool selfDamage, Player damagedPlayer = null)
        {
            
        }

        
        public void Destroy()
        {
            UnityEngine.Object.Destroy(this);
        }
        
    }
}
