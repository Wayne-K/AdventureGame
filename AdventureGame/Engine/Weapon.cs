using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Weapon
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string namePlural { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }
    }
}
