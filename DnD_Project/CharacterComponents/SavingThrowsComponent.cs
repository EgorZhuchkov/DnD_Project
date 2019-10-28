﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Project.CharacterComponents
{
    class SavingThrowsComponent
    {
        //вынести ли enum?
        private Dictionary<StatsEnum, bool> _savingThrows;

        internal void SetSavingThrow(StatsEnum stat, bool value)
        {
            _savingThrows[stat] = value;
        }
        internal bool GetSavingThrow(StatsEnum stat)
        {
            return _savingThrows[stat];
        }
        internal int GetSavingThrowModifier(StatsEnum stat, int statModifier, int proficiencyBonus)
        {
            if(_savingThrows[stat])
            {
                return statModifier + proficiencyBonus;
            }
            else
            {
                return statModifier;
            }   
        }
    }
}