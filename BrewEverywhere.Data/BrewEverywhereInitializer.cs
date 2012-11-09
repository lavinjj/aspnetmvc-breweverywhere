using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace BrewEverywhere.Data
{
    public class BrewEverywhereInitializer : DropCreateDatabaseAlways<BrewEverywhereDBContext>
    {
        protected override void Seed(BrewEverywhereDBContext context)
        {
            // for now do nothing will populate with default data later
        }

    }
}
