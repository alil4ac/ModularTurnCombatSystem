using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularTurnCombatSystem.Units
{
    public abstract class UnitController_Base : MonoBehaviour
    {
        protected MoveContext _moveContext;
        protected AttackContext _attackContext;
        protected HitContext _hitContext;

        protected abstract void Initialize();
    }
}
