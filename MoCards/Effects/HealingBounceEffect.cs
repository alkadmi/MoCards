using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnboundLib;

namespace MoCards.Effects
{
    internal class HealingBounceEffect : DealtDamageEffect
    {
        public override void DealtDamage(Vector2 damage, bool selfDamage, Player damagedPlayer = null)
        {

            if (selfDamage || (damagedPlayer != null && damagedPlayer.teamID == this.gameObject.GetComponent<Player>().teamID))//self or same team
            {

                damagedPlayer.data.healthHandler.Heal(damage.magnitude);
                Unbound.Instance.ExecuteAfterFrames(2, () => damagedPlayer.data.healthHandler.Heal(damage.magnitude));
            }
        }

        public void Destroy()
        {
            UnityEngine.Object.Destroy(this);
        }
    }
}
