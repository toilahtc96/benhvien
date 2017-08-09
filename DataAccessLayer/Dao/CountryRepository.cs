using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface ICountryRepository : DaoInterface<CountryObject> { }

    public class CountryRepository : ICountryRepository
    {
        private DataModel.furniShopEntities db = new DataModel.furniShopEntities();

        public CountryObject Add(CountryObject entity)
        {
            db.SP_Countrys_INSERT(entity.CounttryID, entity.CountryName);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Countrys_DELETE(id);
        }

        public List<CountryObject> GetAll(string[] includes = null)
        {
            var listCountryDb = db.SP_Countrys_GetAll();
            List<CountryObject> ListCountry = new List<CountryObject>();
            foreach (var item in listCountryDb)
            {
                CountryObject cro = new CountryObject();
                cro.CounttryID = item.CountryID;
                cro.CountryName = item.CountryName;
                ListCountry.Add(cro);
            }
            return ListCountry;
        }

        public CountryObject GetByID(Guid id)
        {
            var listCountryDb = db.SP_Countrys_GetByCountryID(id);
            CountryObject cro = new CountryObject();
            foreach (var item in listCountryDb)
            {
                cro.CounttryID = item.CountryID;
                cro.CountryName = item.CountryName;
            }
            return cro;
        }

        public void Update(CountryObject entity)
        {
            db.SP_Countrys_UPDATE(entity.CounttryID, entity.CountryName);
        }
    }
}