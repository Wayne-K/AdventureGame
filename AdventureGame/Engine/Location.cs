﻿using System;
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

        public Location (int locationID, string locationName, string locationDescription)
        {
            ID = locationID;
            name = locationName;
            description = locationDescription;
        }
    }
}
