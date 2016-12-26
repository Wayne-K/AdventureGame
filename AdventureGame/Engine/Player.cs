using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int gold { get; set; }
        public int experiencePoints { get; set; }
        public int level { get; set; }

        public Player(int playerGold, int playerEXP, int playerLevel, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            gold = playerGold;
            experiencePoints = playerEXP;
            level = playerLevel;
        }
    }
}
