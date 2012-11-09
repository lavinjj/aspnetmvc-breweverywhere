using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models.Entities
{
    public class Water
    {
        public Guid Id { get; set; }
        public Guid BrewerId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public double Amount { get; set; } // in liter
        public double Calcium { get; set; }
        public double Bicarbonate { get; set; }
        public double Sulfate { get; set; }
        public double Chloride { get; set; }
        public double Sodium { get; set; }
        public double Magnesium { get; set; }
        public double PH { get; set; }
        public string Notes { get; set; }
    }
}
