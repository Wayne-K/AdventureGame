using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Item itemRequiredToEnter { get; set; }
        public Quest questAvailableHere { get; set; }
        public Monster monsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location (int locationID, string locationName, string locationDescription, Item locationItemRequired = null,
            Quest locationQuestAvailable = null, Monster locationMonsterHere = null)
        {
            ID = locationID;
            name = locationName;
            description = locationDescription;
            itemRequiredToEnter = locationItemRequired;
            questAvailableHere = locationQuestAvailable;
            monsterLivingHere = locationMonsterHere;
        }
    }
}
