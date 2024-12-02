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
            CustomCard.BuildCard<Bouncer>();
            CustomCard.BuildCard<ExtraBounces>();
            CustomCard.BuildCard<LoyalBounces>();
            CustomCard.BuildCard<UnblockableBounces>();
            CustomCard.BuildCard<FasterBounces>();
            CustomCard.BuildCard<ExplosiveBounces>();
            CustomCard.BuildCard<StrongerBounces>();
            CustomCard.BuildCard<AngryBlocker>();
            CustomCard.BuildCard<Crusher>();
            CustomCard.BuildCard<SawAdd>();
            CustomCard.BuildCard<Quasar>();
            CustomCard.BuildCard<Cards.Ping>();
        }
    }
}
