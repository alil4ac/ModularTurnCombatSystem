using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularTurnCombatSystem.Units
{
    public class HitModule : UnitModule_Base<HitContext>, IHitable
    {
        public HitModule(HitContext context) : base(context)
        {
        }

        public void DoHit()
        {
            throw new System.NotImplementedException();
        }
    }
}
