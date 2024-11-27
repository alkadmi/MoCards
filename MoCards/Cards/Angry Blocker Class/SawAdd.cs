using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using MoCards;
using ModdingUtils.Utils;
using UnboundLib.Networking;
using Rounds;
using HarmonyLib;
using ModdingUtils;
using Photon.Pun;
using UnboundLib.Utils;
using static System.Net.Mime.MediaTypeNames;
using ModdingUtils.Extensions;

namespace MoCards.Cards
{
    class SawAdd : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.allowMultiple = false;
            CardInfoExtension.GetAdditionalData(cardInfo).canBeReassigned = false;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            CardInfo cardWithObjectName = ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("Saw");
            ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, cardWithObjectName, false, "", 0f, 0f);
            //Edits values on player when card is selected
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }


        protected override string GetTitle()
        {
            return "Saw Add";
        }
        protected override string GetDescription()
        {
            return "Saw your opponents to death";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "30%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "0.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }
        public override string GetModName()
        {
            return MoCards.ModInitials;
        }
    }
}