using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrewEverywhere.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public Brewer Brewer { get; set; }
        public Guid BrewerId { get; set; }
        public string Name { get; set; }
        public byte[] Version { get; set; }
        public string Type { get; set; } // can only be "Extract", "Partial Mash" or "All Grain"
        public Style Style { get; set; }
        public Guid StyleId { get; set; }
        public List<RecipeEquipment> Equipment { get; set; }
        public string BrewerName { get; set; }
        public string AssistantBrewerName { get; set; }
        public double BatchSize { get; set; } // in liters
        public double BoilSize { get; set; } // in liters
        public double BoilTime { get; set; } // in minutes
        public double BrewHouseEfficiency { get; set; }
        public List<RecipeHop> Hops { get; set; }
        public List<RecipeFermentable> Fermentables { get; set; }
        public List<RecipeAdjunct> Adjuncts { get; set; }
        public List<RecipeYeast> Yeast { get; set; }
        public RecipeWaterProfile WaterProfile { get; set; }
        public Guid WaterProfileId { get; set; }
        public RecipeMashProfile MashProfile { get; set; }
        public Guid MashProfileId { get; set; }
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
