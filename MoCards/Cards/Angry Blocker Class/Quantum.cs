﻿using ClassesManagerReborn.Util;
using CR.MonoBehaviors;
using ModdingUtils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;


namespace MoCards.AngryBlockerCards
{
    class Quantum : CustomCard
    {
        internal static CardInfo card = null;
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.allowMultiple = false;
            CardInfoExtension.GetAdditionalData(cardInfo).canBeReassigned = false;
            block.cdMultiplier = 1.1f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            ((Component)player).gameObject.AddComponent<CR.MonoBehaviors.QuantumMono>();
            //Edits values on player when card is selected
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }

        public override void Callback()
        {
            gameObject.GetOrAddComponent<ClassNameMono>().className = AngryBlockerClass.name;
        }
        protected override string GetTitle()
        {
            return "Quantum";
        }
        protected override string GetDescription()
        {
            return "Blocking near an enemy reactivates your block abilities directly over the nearest enemy!";
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
                new CardInfoStat
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+10%",
                    simepleAmount = (SimpleAmount)0
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Ability Cooldown",
                    amount = "1s",
                    simepleAmount = (SimpleAmount)0
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
