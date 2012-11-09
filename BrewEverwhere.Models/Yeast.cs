using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models
{
    public class Yeast
    {
        public Guid Id { get; set; }
        public Guid BrewerId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public string Type { get; set; } // can be "Ale", "Lager", "Wheat", "Wine" or "Champagne"
        public string Form { get; set; } // can be "Liquid", "Dry", "Slant" or "Culture"
        public double Amount { get; set; } // in liters
        public bool AmountIsWeight { get; set; }
        public string Laboratory { get; set; }
        public string ProductID { get; set; }
        public double MinTemperature { get; set; } // in C
        public double MaxTemperature { get; set; } // in C
        public string Flocculation { get; set; } // can be "Low", "Medium", "High" or "Very High"
        public double Attenuation { get; set; } // percent
        public string Notes { get; set; }
        public string BestFor { get; set; }
        public int TimesCultured { get; set; }
        public int MaxReuse { get; set; }
        public bool AddToSecondary { get; set; }
    }
}
