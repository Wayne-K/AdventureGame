using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Quest
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int rewardEXP { get; set; }
        public int rewardGold { get; set; }
    }
}
