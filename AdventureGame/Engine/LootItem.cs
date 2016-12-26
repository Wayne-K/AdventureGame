using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool isDefaultItem { get; set; }

        public LootItem(Item itemDetails, int itemDropPercentage, bool itemIsDefaultItem)
        {
            Details = itemDetails;
            DropPercentage = itemDropPercentage;
            isDefaultItem = itemIsDefaultItem;
        }
    }
}
