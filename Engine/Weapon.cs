﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int minDamage { get; set; }
        public int maxDamage { get; set; }

        public Weapon(int weaponID, string weaponName, string weaponNamePlural, int weaponMinDamage, int weaponMaxDamage) : base(weaponID, weaponName,
            weaponNamePlural)
        {
            minDamage = weaponMinDamage;
            maxDamage = weaponMaxDamage;
        }
    }
}
