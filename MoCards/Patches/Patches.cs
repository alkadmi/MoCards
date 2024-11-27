using System;
using System.Collections.Generic;
using HarmonyLib;
using ModdingUtils;
using ModdingUtils.Utils;
using Photon.Pun;
using MoCards.Cards;
using UnboundLib.Utils;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using MoCards.Effects;

namespace MoCards.Patches
{
    [Serializable]
    [HarmonyPatch(typeof(HealthHandler), "DoDamage")]
    class HealtHandlerPatchDoDamage
    {
        private static void Prefix(HealthHandler __instance, Vector2 damage, Vector2 position, Color blinkColor, GameObject damagingWeapon, Player damagingPlayer, bool healthRemoval, ref bool lethal, bool ignoreBlock)
        {
            CharacterData data = (CharacterData)Traverse.Create(__instance).Field("data").GetValue();
            Player player = data.player;
            if (!data.isPlaying)
            {
                return;
            }
            if (data.dead)
            {
                return;
            }
            if (__instance.isRespawning)
            {
                return;
            }
            // Any damage
            // Immune if they have self help
            if (player != null && player == damagingPlayer && player.data.GetComponent<NoSelfDamageBounceEffect>() != null)
            {
                player.data.health = Math.Min(player.data.health + (1 * damage.magnitude), player.data.maxHealth * 1 + damage.magnitude);
            }
        }
    }
}
