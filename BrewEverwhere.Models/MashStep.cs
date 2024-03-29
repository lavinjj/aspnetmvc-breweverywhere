﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace BrewEverywhere.Models
{
    public class MashStep
    {
        public Guid Id { get; set; }
        public MashProfile MashProfile { get; set; }
        public Guid MashProfileId { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] Version { get; set; }
        [Required]
        public string Type { get; set; } // can be "Infusion", "Temperature" or "Decoction"
        public double InfuseAmount { get; set; }
        public double Temperature { get; set; } // in C
        public double StepTime { get; set; } // in minutes
        public double RampTime { get; set; } // in minutes
        public double EndTemperature { get; set; }
    }
}
