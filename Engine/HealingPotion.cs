using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int healAmount { get; set; }

        public HealingPotion(int healingPotionID, string healingPotionName, string healingPotionNamePlural, int healingPotionHealAmount) : base(healingPotionID,
            healingPotionName, healingPotionNamePlural)
        {
            healAmount = healingPotionHealAmount;
        }
    }
}
