using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularTurnCombatSystem.Units
{
    public class AllyUnitController : UnitController_Base
    {
        public IMoveable Moveable {  get; private set; }
        public IAttackable Attackable { get; private set; }
        public IHitable Hitable { get; private set; }
        protected override void Initialize()
        {
            Moveable = new MoveModule(this._moveContext);
            Attackable = new AttackModule(this._attackContext);
            Hitable = new HitModule(this._hitContext);
        }

        private void Awake()
        {
            Initialize();
        }
    }
}
