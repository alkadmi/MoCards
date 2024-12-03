using ClassesManagerReborn;
using System.Collections;


namespace MoCards.BouncerCards
{
    class BouncerClass : ClassHandler
    {
        internal static string name = "Bouncer";

        public override IEnumerator Init()
        {
            while (!(Bouncer.card && ExplosiveBounces.card && ExtraBounces.card && FasterBounces.card && LoyalBounces.card && StrongerBounces.card && UnblockableBounces.card))
            {
                yield return null;
            }
            ClassesRegistry.Register(Bouncer.card, (CardType)1);
            ClassesRegistry.Register(ExplosiveBounces.card, (CardType)16, Bouncer.card);
            ClassesRegistry.Register(ExtraBounces.card, (CardType)16, Bouncer.card);
            ClassesRegistry.Register(FasterBounces.card, (CardType)16, Bouncer.card);
            ClassesRegistry.Register(LoyalBounces.card, (CardType)16, Bouncer.card);
            ClassesRegistry.Register(StrongerBounces.card, (CardType)16, Bouncer.card);
            ClassesRegistry.Register(UnblockableBounces.card, (CardType)16, Bouncer.card);

        }
    }

}
