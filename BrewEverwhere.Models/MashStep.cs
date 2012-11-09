using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BrewEverywhere.Models
{
    public class MashStep
    {
        public Guid Id { get; set; }
        public Guid MashProfileId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public string Type { get; set; } // can be "Infusion", "Temperature" or "Decoction"
        public double InfuseAmount { get; set; }
        public double Temperature { get; set; } // in C
        public double StepTime { get; set; } // in minutes
        public double RampTime { get; set; } // in minutes
        public double EndTemperature { get; set; }
    }
}
