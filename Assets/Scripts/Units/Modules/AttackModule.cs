using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularTurnCombatSystem.Units
{
    public class AttackModule : UnitModule_Base<AttackContext>, IAttackable
    {
        public AttackModule(AttackContext context) : base(context)
        {
        }

        public void DoAttack()
        {
            throw new System.NotImplementedException();
        }
    }
}
