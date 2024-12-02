using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using ClassesManagerReborn;
using MoCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using UnityEngine;
using System.Collections.Generic;
using MoCards.Patches;
using System;



namespace MoCards
{
    // These are the mods required for our mod to work
    [BepInDependency("root.classes.manager.reborn")]
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class MoCards : BaseUnityPlugin
    {
        private const string ModId = "com.rounds.alkadmi.MoCards";
        private const string ModName = "MoCards";
        public const string Version = "0.1.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "MC";

        public static MoCards instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony("com.rounds.alkadmi.MoCards");
            harmony.PatchAll();
            
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<Bouncer>((card) => Bouncer.card = card);
            CustomCard.BuildCard<ExtraBounces>((card) => ExtraBounces.card = card);
            CustomCard.BuildCard<LoyalBounces>((card) => LoyalBounces.card = card);
            CustomCard.BuildCard<UnblockableBounces>((card) => UnblockableBounces.card = card);
            CustomCard.BuildCard<FasterBounces>((card) => FasterBounces.card = card);
            CustomCard.BuildCard<ExplosiveBounces>((card) => ExplosiveBounces.card = card);
            CustomCard.BuildCard<StrongerBounces>((card) => StrongerBounces.card = card);
            CustomCard.BuildCard<AngryBlocker>((card) => AngryBlocker.card = card);
            CustomCard.BuildCard<Crusher>((card) => Crusher.card = card);
            CustomCard.BuildCard<SawAdd>(((card) => SawAdd.card = card));
            CustomCard.BuildCard<Quasar>((card) => Quasar.card = card);
            CustomCard.BuildCard<Cards.Ping>((card) => Cards.Ping.card = card);
            CustomCard.BuildCard<Holster>((card) => Holster.card = card);
            CustomCard.BuildCard<Quantum>((card) => Quantum.card = card);
            CustomCard.BuildCard<EmpowerAdd>((card) => EmpowerAdd.card = card);
            CustomCard.BuildCard<FrostSlamAdd>((card) => FrostSlamAdd.card = card);
            CustomCard.BuildCard<ImplodeAdd>((card) => ImplodeAdd.card = card);
            CustomCard.BuildCard<StaticFieldAdd>((card) => StaticFieldAdd.card = card);
            CustomCard.BuildCard<SupernovaAdd>((card) => SupernovaAdd.card = card);
            CustomCard.BuildCard<GetCloser>((card) => GetCloser.card = card);
        }
    }
}
