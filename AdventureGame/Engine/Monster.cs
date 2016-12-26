using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int maxHP { get; set; }
        public int currentHP { get; set; }
        public int maxDamage { get; set; }
        public int rewardEXP { get; set; }
        public int rewardGold { get; set; }
    }
}
