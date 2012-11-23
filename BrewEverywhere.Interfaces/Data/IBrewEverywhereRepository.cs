using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrewEverywhere.Models;

namespace BrewEverywhere.Interfaces.Data
{
    public interface IBrewEverywhereRepository
    {
        Account GetUserAccount(Guid id);
        Account GetUserAccountByUserName(string userName);
        bool AddUserAccount(Account value);
        bool UpdateUserAccount(Account value);
        bool DeleteUserAccount(Account value);

        Brewer GetBrewer(Guid id);
        Brewer GetBrewerByEmail(string email);
        Brewer GetBrewerByUserName(string userName);
        bool AddBrewer(Brewer value);
        bool UpdateBrewer(Brewer value);
        bool DeleteBrewer(Brewer value);

        List<Adjunct> Adjuncts();
        bool AddAdjunct(Adjunct value);
        bool UpdateAdjunct(Adjunct value);
        bool DeleteAdjunct(Adjunct value);

        List<Equipment> Equipment();
        bool AddEquipment(Equipment value);
        bool UpdateEquipment(Equipment value);
        bool DeleteEquipment(Equipment value);

        List<Fermentable> Fermentables();
        bool AddFermentable(Fermentable value);
        bool UpdateFermentable(Fermentable value);
        bool DeleteFermentable(Fermentable value);

        List<Hop> Hops();
        bool AddHop(Hop value);
        bool UpdateHop(Hop value);
        bool DeleteHop(Hop value);

        List<MashProfile> MashProfiles();
        bool AddMashProfile(MashProfile value);
        bool UpdateMashProfile(MashProfile value);
        bool DeleteMashProfile(MashProfile value);

        List<Style> Styles();
        bool AddStyle(Style value);
        bool UpdateStyle(Style value);
        bool DeleteStyle(Style value);

        List<WaterProfile> WaterProfiles();
        bool AddWaterProfile(WaterProfile value);
        bool UpdateWaterProfile(WaterProfile value);
        bool DeleteWaterProfile(WaterProfile value);

        List<Yeast> Yeasts();
        bool AddYeast(Yeast value);
        bool UpdateYeast(Yeast value);
        bool DeleteYeast(Yeast value);

        List<Recipe> Recipes();
    }
}
