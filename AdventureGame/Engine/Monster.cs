using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int maxDamage { get; set; }
        public int rewardEXP { get; set; }
        public int rewardGold { get; set; }
    }
}
