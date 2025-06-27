using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularTurnCombatSystem.Units
{
    public class MoveModule : UnitModule_Base<MoveContext>, IMoveable
    {
        public MoveModule(MoveContext context) : base(context)
        { 
        }

        public void SetMove()
        {

        }
    }
}
