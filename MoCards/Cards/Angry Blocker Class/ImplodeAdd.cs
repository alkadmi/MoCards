﻿using ClassesManagerReborn.Util;
using ModdingUtils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;


namespace MoCards.Cards
{
    class ImplodeAdd : CustomCard
    {
        internal static CardInfo card = null;
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.allowMultiple = false;
            CardInfoExtension.GetAdditionalData(cardInfo).canBeReassigned = false;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            //UnityEngine.Debug.Log($"[{MoCards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            CardInfo cardWithObjectName = ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("Implode");
            ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, cardWithObjectName, false, "", 0f, 0f);
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
            ExtensionMethods.GetOrAddComponent<ClassNameMono>(((Component)this).gameObject, false).className = AngryBlockerClass.name;
        }
        protected override string GetTitle()
        {
            return "Implode Add";
        }
        protected override string GetDescription()
        {
            return "blocking pulls enemies towards you";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+0.25s",
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