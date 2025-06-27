using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularTurnCombatSystem.Units
{
    public abstract class UnitModule_Base<T> where T : struct
    {
        protected T _context { get; set; }

        public UnitModule_Base(T context)
        {
            _context = context;
        }
    }
}
