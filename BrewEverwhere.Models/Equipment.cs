using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models
{
    public class Equipment
    {
        public Guid Id { get; set; }
        public Guid BrewerId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public double BoilSize { get; set; }
        public double BatchSize { get; set; }
        public double TUNVolume { get; set; }
        public double TUNWeight { get; set; }
        public double TUNSpecificHeat { get; set; }
        public double TopUpWater { get; set; }
        public double TrubChillerLoss { get; set; }
        public double EvapRate { get; set; } // percent
        public double BoilTime { get; set; }
        public bool CalcBoilTime { get; set; }
        public double LauterDeadspace { get; set; }
        public double TopUpKettle { get; set; }
        public double HopUtilization { get; set; } // percent
        public string Notes { get; set; }
    }
}
