﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models
{
    public class Adjunct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public string Type { get; set; } // can be "Spice", "Fining", "Water Agent", "Herb", "Flavor" or "Other"
        public string Use { get; set; } // can be "Boil", "Mash", "Primary", "Secondary" or "Bottling"
        public double Time { get; set; } // in minutes
        public double Amount { get; set; } // liters or kg
        public bool AmountIsWeight { get; set; }
        public string UseFor { get; set; }
        public string Notes { get; set; }
    }

    public class InventoryAdjunct : Adjunct
    {
        public Guid BrewerId { get; set; }
    }

    public class RecipeAdjunct : Adjunct
    {
        public Guid RecipeId { get; set; }
    }
}
