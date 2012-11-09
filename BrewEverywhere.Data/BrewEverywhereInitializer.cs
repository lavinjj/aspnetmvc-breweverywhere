using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    public class BrewEverywhereInitializer : DropCreateDatabaseAlways<BrewEverywhereDBContext>
    {
        protected override void Seed(BrewEverywhereDBContext context)
        {
            // for now do nothing will populate with default data later
            // populate styles table
            new List<Style> {
                   new Style {OGMin=1.045, OGMax=1.060, FGMin=1.010, FGMax=1.015, IBUMin=25, IBUMax=40,  ColorMin=10, ColorMax=17, Name="American Amber Ale"},
                   new Style {OGMin=1.080, OGMax=1.120, FGMin=1.016, FGMax=1.030, IBUMin=50, IBUMax=120, ColorMin=10, ColorMax=19, Name="American Barleywine"},
                   new Style {OGMin=1.045, OGMax=1.060, FGMin=1.010, FGMax=1.016, IBUMin=20, IBUMax=40,  ColorMin=18, ColorMax=35, Name="American Brown Ale"},
                   new Style {OGMin=1.056, OGMax=1.075, FGMin=1.010, FGMax=1.018, IBUMin=40, IBUMax=60,  ColorMin=6, ColorMax=15, Name="American IPA"},
                   new Style {OGMin=1.045, OGMax=1.060, FGMin=1.010, FGMax=1.015, IBUMin=30, IBUMax=45,  ColorMin=5, ColorMax=14, Name="American Pale Ale"},
                   new Style {OGMin=1.050, OGMax=1.075, FGMin=1.010, FGMax=1.022, IBUMin=35, IBUMax=75,  ColorMin=30, ColorMax=40, Name="American Stout"},
                   new Style {OGMin=1.040, OGMax=1.055, FGMin=1.008, FGMax=1.013, IBUMin=15, IBUMax=30,  ColorMin=3, ColorMax=6, Name="American Wheat or Rye Beer"},
                   new Style {OGMin=1.060, OGMax=1.090, FGMin=1.016, FGMax=1.024, IBUMin=20, IBUMax=40,  ColorMin=17, ColorMax=30, Name="Baltic Porter"},
                   new Style {OGMin=1.062, OGMax=1.075, FGMin=1.008, FGMax=1.016, IBUMin=20, IBUMax=30,  ColorMin=4, ColorMax=6, Name="Belgian Blond Ale"},
                   new Style {OGMin=1.075, OGMax=1.110, FGMin=1.010, FGMax=1.024, IBUMin=15, IBUMax=25,  ColorMin=14, ColorMax=20, Name="Belgian Dark Strong Ale"},
                   new Style {OGMin=1.062, OGMax=1.075, FGMin=1.010, FGMax=1.018, IBUMin=15, IBUMax=25,  ColorMin=10, ColorMax=14, Name="Belgian Dubbel"},
                   new Style {OGMin=1.070, OGMax=1.095, FGMin=1.010, FGMax=1.016, IBUMin=25, IBUMax=35,  ColorMin=4, ColorMax=6, Name="Belgian Golden Strong Ale"},
                   new Style {OGMin=1.048, OGMax=1.054, FGMin=1.010, FGMax=1.014, IBUMin=20, IBUMax=30,  ColorMin=8, ColorMax=14, Name="Belgian Pale Ale"},
                   new Style {OGMin=1.040, OGMax=1.075, FGMin=1.000, FGMax=1.016, IBUMin=2, IBUMax=40,  ColorMin=3, ColorMax=20, Name="Belgian Specialty Ale"},
                   new Style {OGMin=1.075, OGMax=1.085, FGMin=1.010, FGMax=1.016, IBUMin=25, IBUMax=38,  ColorMin=4, ColorMax=6, Name="Belgian Tripel"},
                   new Style {OGMin=1.028, OGMax=1.032, FGMin=1.004, FGMax=1.006, IBUMin=3, IBUMax=8,  ColorMin=2, ColorMax=3, Name="Berliner Weisse"},
                   new Style {OGMin=1.060, OGMax=1.080, FGMin=1.012, FGMax=1.018, IBUMin=20, IBUMax=30,  ColorMin=6, ColorMax=19, Name="Biere de Garde"},
                   new Style {OGMin=1.038, OGMax=1.054, FGMin=1.008, FGMax=1.013, IBUMin=15, IBUMax=28,  ColorMin=3, ColorMax=6, Name="Blonde Ale"},
                   new Style {OGMin=1.044, OGMax=1.056, FGMin=1.013, FGMax=1.017, IBUMin=35, IBUMax=45,  ColorMin=3, ColorMax=6, Name="Bohemian Pilsener"},
                   new Style {OGMin=1.060, OGMax=1.120, FGMin=1.015, FGMax=1.030, IBUMin=0, IBUMax=50,  ColorMin=3, ColorMax=16, Name="Braggot"},
                   new Style {OGMin=1.040, OGMax=1.052, FGMin=1.008, FGMax=1.014, IBUMin=18, IBUMax=35,  ColorMin=20, ColorMax=30, Name="Brown Porter"},
                   new Style {OGMin=1.048, OGMax=1.054, FGMin=1.011, FGMax=1.014, IBUMin=30, IBUMax=45,  ColorMin=10, ColorMax=14, Name="California Common Beer"},
                   new Style {OGMin=1.044, OGMax=1.060, FGMin=1.010, FGMax=1.015, IBUMin=25, IBUMax=40,  ColorMin=3, ColorMax=6, Name="Classic American Pilsner"},
                   new Style {OGMin=1.050, OGMax=1.056, FGMin=1.012, FGMax=1.016, IBUMin=20, IBUMax=30,  ColorMin=14, ColorMax=22, Name="Classic Rauchbier"},
                   new Style {OGMin=1.042, OGMax=1.055, FGMin=1.006, FGMax=1.012, IBUMin=15, IBUMax=20,  ColorMin=2, ColorMax=5, Name="Cream Ale"},
                   new Style {OGMin=1.044, OGMax=1.056, FGMin=1.008, FGMax=1.012, IBUMin=8, IBUMax=20,  ColorMin=14, ColorMax=22, Name="Dark American Lager"},
                   new Style {OGMin=1.072, OGMax=1.096, FGMin=1.016, FGMax=1.024, IBUMin=16, IBUMax=26,  ColorMin=6, ColorMax=25, Name="Doppelbock"},
                   new Style {OGMin=1.048, OGMax=1.056, FGMin=1.010, FGMax=1.015, IBUMin=23, IBUMax=30,  ColorMin=4, ColorMax=6, Name="Dortmunder Export"},
                   new Style {OGMin=1.036, OGMax=1.050, FGMin=1.007, FGMax=1.011, IBUMin=30, IBUMax=45,  ColorMin=25, ColorMax=40, Name="Dry Stout"},
                   new Style {OGMin=1.044, OGMax=1.056, FGMin=1.010, FGMax=1.014, IBUMin=10, IBUMax=18,  ColorMin=14, ColorMax=23, Name="Dunkelweizen"},
                   new Style {OGMin=1.046, OGMax=1.054, FGMin=1.010, FGMax=1.015, IBUMin=35, IBUMax=50,  ColorMin=13, ColorMax=17, Name="Dusseldorf Altbier"},
                   new Style {OGMin=1.078, OGMax=1.120, FGMin=1.020, FGMax=1.035, IBUMin=25, IBUMax=35,  ColorMin=18, ColorMax=30, Name="Eisbock"},
                   new Style {OGMin=1.080, OGMax=1.120, FGMin=1.018, FGMax=1.030, IBUMin=35, IBUMax=70,  ColorMin=8, ColorMax=22, Name="English Barleywine"},
                   new Style {OGMin=1.050, OGMax=1.075, FGMin=1.010, FGMax=1.018, IBUMin=40, IBUMax=60,  ColorMin=8, ColorMax=14, Name="English IPA"},
                   new Style {OGMin=1.048, OGMax=1.060, FGMin=1.010, FGMax=1.016, IBUMin=30, IBUMax=50,  ColorMin=6, ColorMax=18, Name="Extra Special/Strong Bitter (English Pale Ale)"},
                   new Style {OGMin=1.043, OGMax=1.077, FGMin=1.012, FGMax=1.016, IBUMin=15, IBUMax=25,  ColorMin=15, ColorMax=20, Name="Flanders Brown Ale/Oud Bruin"},
                   new Style {OGMin=1.046, OGMax=1.054, FGMin=1.008, FGMax=1.016, IBUMin=15, IBUMax=25,  ColorMin=10, ColorMax=16, Name="Flanders Red Ale"},
                   new Style {OGMin=1.056, OGMax=1.075, FGMin=1.010, FGMax=1.018, IBUMin=30, IBUMax=70,  ColorMin=30, ColorMax=40, Name="Foreign Extra Stout"},
                   new Style {OGMin=1.030, OGMax=1.080, FGMin=1.008, FGMax=1.020, IBUMin=10, IBUMax=40,  ColorMin=2, ColorMax=35, Name="Fruit Beer"},
                   new Style {OGMin=1.040, OGMax=1.060, FGMin=1.000, FGMax=1.010, IBUMin=2, IBUMax=10,  ColorMin=3, ColorMax=7, Name="Fruit Lambic"},
                   new Style {OGMin=1.020, OGMax=1.120, FGMin=1.005, FGMax=1.030, IBUMin=1, IBUMax=70,  ColorMin=1, ColorMax=40, Name="Generic Ale"},
                   new Style {OGMin=1.044, OGMax=1.050, FGMin=1.008, FGMax=1.013, IBUMin=25, IBUMax=45,  ColorMin=2, ColorMax=5, Name="German Pilsner (Pils)"},
                   new Style {OGMin=1.040, OGMax=1.060, FGMin=1.000, FGMax=1.006, IBUMin=2, IBUMax=10,  ColorMin=3, ColorMax=7, Name="Gueuze"},
                   new Style {OGMin=1.075, OGMax=1.090, FGMin=1.012, FGMax=1.020, IBUMin=60, IBUMax=100, ColorMin=8, ColorMax=15, Name="Imperial IPA"},
                   new Style {OGMin=1.075, OGMax=1.095, FGMin=1.018, FGMax=1.030, IBUMin=50, IBUMax=90,  ColorMin=30, ColorMax=40, Name="Imperial Stout"},
                   new Style {OGMin=1.044, OGMax=1.060, FGMin=1.010, FGMax=1.014, IBUMin=17, IBUMax=28,  ColorMin=9, ColorMax=18, Name="Irish Red Ale"},
                   new Style {OGMin=1.042, OGMax=1.056, FGMin=1.010, FGMax=1.023, IBUMin=25, IBUMax=38,  ColorMin=30, ColorMax=40, Name="Irish Stout"},
                   new Style {OGMin=1.044, OGMax=1.050, FGMin=1.007, FGMax=1.011, IBUMin=20, IBUMax=30,  ColorMin=3, ColorMax=5, Name="Kolsch"},
                   new Style {OGMin=1.030, OGMax=1.040, FGMin=0.998, FGMax=1.008, IBUMin=8, IBUMax=12,  ColorMin=2, ColorMax=3, Name="Lite American Lager"},
                   new Style {OGMin=1.064, OGMax=1.072, FGMin=1.011, FGMax=1.018, IBUMin=23, IBUMax=35,  ColorMin=6, ColorMax=11, Name="Maibock/Helles Bock"},
                   new Style {OGMin=1.030, OGMax=1.038, FGMin=1.008, FGMax=1.013, IBUMin=10, IBUMax=25,  ColorMin=12, ColorMax=25, Name="Mild"},
                   new Style {OGMin=1.042, OGMax=1.056, FGMin=1.010, FGMax=1.023, IBUMin=25, IBUMax=40,  ColorMin=30, ColorMax=40, Name="Milk Stout"},
                   new Style {OGMin=1.048, OGMax=1.056, FGMin=1.010, FGMax=1.016, IBUMin=18, IBUMax=28,  ColorMin=14, ColorMax=28, Name="Munich Dunkel"},
                   new Style {OGMin=1.045, OGMax=1.051, FGMin=1.008, FGMax=1.012, IBUMin=16, IBUMax=22,  ColorMin=3, ColorMax=5, Name="Munich Helles"},
                   new Style {OGMin=1.046, OGMax=1.054, FGMin=1.010, FGMax=1.015, IBUMin=25, IBUMax=40,  ColorMin=13, ColorMax=19, Name="North German Altbier"},
                   new Style {OGMin=1.040, OGMax=1.052, FGMin=1.008, FGMax=1.013, IBUMin=20, IBUMax=30,  ColorMin=12, ColorMax=22, Name="Northern English Brown Ale"},
                   new Style {OGMin=1.048, OGMax=1.065, FGMin=1.010, FGMax=1.018, IBUMin=25, IBUMax=40,  ColorMin=22, ColorMax=40, Name="Oatmeal Stout"},
                   new Style {OGMin=1.050, OGMax=1.056, FGMin=1.012, FGMax=1.016, IBUMin=20, IBUMax=28,  ColorMin=7, ColorMax=14, Name="Oktoberfest/Marzen"},
                   new Style {OGMin=1.060, OGMax=1.090, FGMin=1.015, FGMax=1.022, IBUMin=30, IBUMax=60,  ColorMin=10, ColorMax=22, Name="Old Ale"},
                   new Style {OGMin=1.046, OGMax=1.056, FGMin=1.008, FGMax=1.012, IBUMin=15, IBUMax=25,  ColorMin=2, ColorMax=6, Name="Premium American Lager"},
                   new Style {OGMin=1.048, OGMax=1.065, FGMin=1.012, FGMax=1.016, IBUMin=25, IBUMax=50,  ColorMin=22, ColorMax=35, Name="Robust Porter"},
                   new Style {OGMin=1.046, OGMax=1.056, FGMin=1.010, FGMax=1.014, IBUMin=10, IBUMax=20,  ColorMin=14, ColorMax=19, Name="Roggenbier (German Rye Beer)"},
                   new Style {OGMin=1.048, OGMax=1.080, FGMin=1.010, FGMax=1.016, IBUMin=25, IBUMax=45,  ColorMin=5, ColorMax=12, Name="Saison"},
                   new Style {OGMin=1.046, OGMax=1.052, FGMin=1.010, FGMax=1.016, IBUMin=22, IBUMax=32,  ColorMin=17, ColorMax=30, Name="Schwarzbier"},
                   new Style {OGMin=1.040, OGMax=1.054, FGMin=1.010, FGMax=1.016, IBUMin=15, IBUMax=30,  ColorMin=9, ColorMax=17, Name="Scottish Export 80/-"},
                   new Style {OGMin=1.035, OGMax=1.040, FGMin=1.010, FGMax=1.015, IBUMin=10, IBUMax=25,  ColorMin=9, ColorMax=17, Name="Scottish Heavy 70/-"},
                   new Style {OGMin=1.030, OGMax=1.035, FGMin=1.010, FGMax=1.013, IBUMin=10, IBUMax=20,  ColorMin=9, ColorMax=17, Name="Scottish Light 60/-"},
                   new Style {OGMin=1.035, OGMax=1.042, FGMin=1.011, FGMax=1.014, IBUMin=12, IBUMax=20,  ColorMin=19, ColorMax=35, Name="Southern English Brown Ale"},
                   new Style {OGMin=1.040, OGMax=1.048, FGMin=1.008, FGMax=1.012, IBUMin=25, IBUMax=40,  ColorMin=5, ColorMax=16, Name="Special/Best/Premium Bitter"},
                   new Style {OGMin=1.030, OGMax=1.080, FGMin=1.008, FGMax=1.020, IBUMin=10, IBUMax=40,  ColorMin=2, ColorMax=35, Name="Spice, Herb or Vegetable Beer"},
                   new Style {OGMin=1.040, OGMax=1.050, FGMin=1.004, FGMax=1.010, IBUMin=8, IBUMax=15,  ColorMin=2, ColorMax=4, Name="Standard American Lager"},
                   new Style {OGMin=1.032, OGMax=1.040, FGMin=1.007, FGMax=1.011, IBUMin=25, IBUMax=35,  ColorMin=4, ColorMax=14, Name="Standard/Ordinary Bitter"},
                   new Style {OGMin=1.040, OGMax=1.054, FGMin=1.000, FGMax=1.010, IBUMin=2, IBUMax=10,  ColorMin=3, ColorMax=7, Name="Straight (Unblended) Lambic"},
                   new Style {OGMin=1.070, OGMax=1.130, FGMin=1.018, FGMax=1.030, IBUMin=17, IBUMax=35,  ColorMin=14, ColorMax=25, Name="Strong Scotch Ale"},
                   new Style {OGMin=1.042, OGMax=1.056, FGMin=1.010, FGMax=1.023, IBUMin=25, IBUMax=40,  ColorMin=30, ColorMax=40, Name="Sweet Stout"},
                   new Style {OGMin=1.064, OGMax=1.072, FGMin=1.013, FGMax=1.019, IBUMin=20, IBUMax=27,  ColorMin=14, ColorMax=22, Name="Traditional Bock"},
                   new Style {OGMin=1.046, OGMax=1.052, FGMin=1.010, FGMax=1.014, IBUMin=18, IBUMax=30,  ColorMin=10, ColorMax=16, Name="Vienna Lager"},
                   new Style {OGMin=1.044, OGMax=1.052, FGMin=1.010, FGMax=1.014, IBUMin=8, IBUMax=15,  ColorMin=2, ColorMax=8, Name="Weizen/Weissbier"},
                   new Style {OGMin=1.064, OGMax=1.080, FGMin=1.015, FGMax=1.022, IBUMin=15, IBUMax=30,  ColorMin=12, ColorMax=25, Name="Weizenbock"},
                   new Style {OGMin=1.044, OGMax=1.052, FGMin=1.008, FGMax=1.012, IBUMin=10, IBUMax=20,  ColorMin=2, ColorMax=4, Name="Witbier"}
            }.ForEach(s => context.Styles.Add(s));

            base.Seed(context);
        }

    }
}
