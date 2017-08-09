using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface ICompanyRepository : DaoInterface<CompanyObject> { }
    public class CompanyRepository :ICompanyRepository
    {
        private DataModel.furniShopEntities db = new DataModel.furniShopEntities();

        public CompanyObject Add(CompanyObject entity)
        {
            db.SP_Companys_INSERT(entity.CompanyID, entity.CompanyName);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Companys_DELETE(id);
        }

        public List<CompanyObject> GetAll(string[] includes = null)
        {
            var listCompanyDb = db.SP_Companys_GetAll();
            List<CompanyObject> ListCompany = new List<CompanyObject>();
            foreach (var item in listCompanyDb)
            {
                CompanyObject cpo = new CompanyObject();
                cpo.CompanyID = item.CompanyID;
                cpo.CompanyName = item.CompanyName;
                ListCompany.Add(cpo);
            }
            return ListCompany;
        }

        public CompanyObject GetByID(Guid id)
        {
            var CompanyDb = db.SP_Companys_GetByCompanyID(id);
            CompanyObject cpo = new CompanyObject();
            foreach (var item in CompanyDb)
            {
                cpo.CompanyID = item.CompanyID;
                cpo.CompanyName = item.CompanyName;
            }
            return cpo;
        }

        public void Update(CompanyObject entity)
        {
            db.SP_Companys_UPDATE(entity.CompanyID, entity.CompanyName);
        }
    }
}