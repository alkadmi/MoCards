using ClassesManagerReborn;
using System.Collections;


namespace MoCards.Cards
{
    class AngryBlockerClass : ClassHandler
    {
        internal static string name = "Angry Blocker";
        public override IEnumerator Init()
        {
            while (!(AngryBlocker.card && Crusher.card && EmpowerAdd.card && FrostSlamAdd.card && GetCloser.card && Holster.card &&
                ImplodeAdd.card && Ping.card && Quantum.card && Quasar.card && SawAdd.card && StaticFieldAdd.card && SupernovaAdd.card))
            {
                yield return null;
            }
            ClassesRegistry.Register(AngryBlocker.card, CardType.Entry);
            ClassesRegistry.Register(Crusher.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(EmpowerAdd.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(FrostSlamAdd.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(GetCloser.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(Holster.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(ImplodeAdd.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(Ping.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(Quantum.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(Quasar.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(SawAdd.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(StaticFieldAdd.card, CardType.Card, AngryBlocker.card);
            ClassesRegistry.Register(SupernovaAdd.card, CardType.Card, AngryBlocker.card);
        }
    }
}