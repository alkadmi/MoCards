using ClassesManagerReborn;
using System.Collections;


namespace MoCards.Cards
{
    class BouncerClass : ClassHandler
    {
        internal static string name = "Bouncer";

        public override IEnumerator Init()
        {
            while (!(Bouncer.card && ExplosiveBounces.card && ExtraBounces.card && FasterBounces.card && LoyalBounces.card && StrongerBounces.card && UnblockableBounces.card)) yield return null;
            {
                ClassesRegistry.Register(Bouncer.card, CardType.Entry);
                ClassesRegistry.Register(ExplosiveBounces.card, CardType.Card, Bouncer.card);
                ClassesRegistry.Register(ExtraBounces.card, CardType.Entry, Bouncer.card);
                ClassesRegistry.Register(FasterBounces.card, CardType.Entry, Bouncer.card);
                ClassesRegistry.Register(LoyalBounces.card, CardType.Card, Bouncer.card);
                ClassesRegistry.Register(StrongerBounces.card, CardType.Card, Bouncer.card);
                ClassesRegistry.Register(UnblockableBounces.card, CardType.Entry, Bouncer.card);
            }

        }
    }
    
}
