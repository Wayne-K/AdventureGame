using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string namePlural { get; set; }
        
        public Item (int itemID, string itemName, string itemNamePlural)
        {
            ID = itemID;
            name = itemName;
            namePlural = itemNamePlural;
        }
    }
}
