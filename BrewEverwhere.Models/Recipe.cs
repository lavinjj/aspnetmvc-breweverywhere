using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace BrewEverywhere.Models.Entities
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public Guid BrewerId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public string Type { get; set; } // can only be "Extract", "Partial Mash" or "All Grain"
        public Collection<Style> Styles { get; set; }
        public Collection<Equipment> Equipment { get; set; }
        public string BrewerName { get; set; }
        public string AssistantBrewerName { get; set; }
        public double BatchSize { get; set; } // in liters
        public double BoilSize { get; set; } // in liters
        public double BoilTime { get; set; } // in minutes
        public double BrewHouseEfficiency { get; set; }
        public Collection<Hop> Hops { get; set; }
        public Collection<Fermentable> Fermentables { get; set; }
        public Collection<Adjunct> Adjuncts { get; set; }
        public Collection<Yeast> Yeast { get; set; }
        public Collection<Water> Water { get; set; }
        public Collection<Mash> Mash { get; set; }
        public string Notes { get; set; }
        public string TasteNotes { get; set; }
        public double TasteRating { get; set; } // 0-50.0
        public double OriginalGravity { get; set; }
        public double FinalGravity { get; set; }
        public int FermentationStages { get; set; }
        public double PrimaryAge { get; set; } // in days
        public double PrimaryTemp { get; set; } // in C
        public double SecondaryAge { get; set; } // in days
        public double SecondaryTemp { get; set; } // in C
        public double TertiaryAge { get; set; } // in days
        public double TertiaryTemp { get; set; } // in C
        public double ConditioningAge { get; set; } // bottle conditioning age in days
        public double ConditioningAgeTemp { get; set; } // temp to age bottles in C
        public string Date { get; set; } // date brewed
        public double Carbonation { get; set; } // carbonation in vol of CO2
        public bool ForcedCarbonation { get; set; }
        public string PrimingSugarName { get; set; }
        public double CarbonationTemp { get; set; }
        public double PrimingSugarEquiv { get; set; }
        public double KegPrimingFactor { get; set; }
    }
}
