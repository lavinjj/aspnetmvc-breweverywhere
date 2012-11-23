using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using BrewEverywhere.Interfaces.Data;
using BrewEverywhere.Interfaces.Logging;
using BrewEverywhere.Models;

namespace BrewEverywhere.Data
{
    public class BrewEverywhereRepository : IBrewEverywhereRepository
    {
        private ILoggerService _logService;

        public BrewEverywhereRepository(ILoggerService logService)
        {
            _logService = logService;
        }

        public Account GetUserAccount(Guid id)
        {
            Account result = null;

            using (var db = new BrewEverywhereDBContext())
            {
                result = db.Accounts.Where(a => a.Id == id).FirstOrDefault();
            }

            return result;
        }

        public Account GetUserAccountByUserName(string userName)
        {
            Account result = null;

            using (var db = new BrewEverywhereDBContext())
            {
                result = db.Accounts.Where(a => a.userName == userName).FirstOrDefault();
            }

            return result;
        }

        public bool AddUserAccount(Account value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Accounts.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateUserAccount(Account value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Accounts.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteUserAccount(Account value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Accounts.Attach(value);
                    db.Accounts.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public Brewer GetBrewer(Guid id)
        {
            Brewer result = null;

            using (var db = new BrewEverywhereDBContext())
            {
                result = db.Brewers.Where(a => a.Id == id).FirstOrDefault();
            }

            return result;
        }

        public Brewer GetBrewerByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Brewer GetBrewerByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public bool AddBrewer(Brewer value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Brewers.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateBrewer(Brewer value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Brewers.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteBrewer(Brewer value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Brewers.Attach(value);
                    db.Brewers.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Adjunct> Adjuncts()
        {
            throw new NotImplementedException();
        }

        public bool AddAdjunct(Adjunct value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Adjuncts.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateAdjunct(Adjunct value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Adjuncts.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteAdjunct(Adjunct value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Adjuncts.Attach(value);
                    db.Adjuncts.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Equipment> Equipment()
        {
            throw new NotImplementedException();
        }

        public bool AddEquipment(Equipment value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.EquipmentProfiles.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateEquipment(Equipment value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.EquipmentProfiles.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteEquipment(Equipment value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.EquipmentProfiles.Attach(value);
                    db.EquipmentProfiles.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Fermentable> Fermentables()
        {
            throw new NotImplementedException();
        }

        public bool AddFermentable(Fermentable value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Fermentables.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateFermentable(Fermentable value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Fermentables.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteFermentable(Fermentable value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Fermentables.Attach(value);
                    db.Fermentables.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Hop> Hops()
        {
            throw new NotImplementedException();
        }

        public bool AddHop(Hop value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Hops.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateHop(Hop value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Hops.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteHop(Hop value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Hops.Attach(value);
                    db.Hops.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<MashProfile> MashProfiles()
        {
            throw new NotImplementedException();
        }

        public bool AddMashProfile(MashProfile value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.MashProfiles.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateMashProfile(MashProfile value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.MashProfiles.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteMashProfile(MashProfile value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.MashProfiles.Attach(value);
                    db.MashProfiles.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Style> Styles()
        {
            throw new NotImplementedException();
        }

        public bool AddStyle(Style value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Styles.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateStyle(Style value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Styles.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteStyle(Style value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Styles.Attach(value);
                    db.Styles.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<WaterProfile> WaterProfiles()
        {
            throw new NotImplementedException();
        }

        public bool AddWaterProfile(WaterProfile value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.WaterProfiles.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateWaterProfile(WaterProfile value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.WaterProfiles.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteWaterProfile(WaterProfile value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.WaterProfiles.Attach(value);
                    db.WaterProfiles.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Yeast> Yeasts()
        {
            throw new NotImplementedException();
        }

        public bool AddYeast(Yeast value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Yeasts.Add(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool UpdateYeast(Yeast value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Yeasts.Attach(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public bool DeleteYeast(Yeast value)
        {
            bool result = false;

            try
            {
                using (var db = new BrewEverywhereDBContext())
                {
                    db.Yeasts.Attach(value);
                    db.Yeasts.Remove(value);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logService.Fatal(ex.Message);
                _logService.Fatal(ex.StackTrace);
            }

            return result;
        }

        public List<Recipe> Recipes()
        {
            throw new NotImplementedException();
        }
    }
}
