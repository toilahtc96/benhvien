using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IFooterRepository : DaoInterface<FooterObject> { }

    public class FooterRepository : IFooterRepository
    {
        private DataModel.furniShopEntities db = new DataModel.furniShopEntities();

        public FooterObject Add(FooterObject entity)
        {
            db.SP_Footers_INSERT(entity.FooterID, entity.FooterName);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Footers_DELETE(id);
        }

        public List<FooterObject> GetAll(string[] includes = null)
        {
            var listFooterDb = db.SP_Footers_GetAll();
            List<FooterObject> ListFooter = new List<FooterObject>();
            foreach (var item in listFooterDb)
            {
                FooterObject fto = new FooterObject();
                fto.FooterID = item.FooterID;
                fto.FooterName = item.FooterName;
                ListFooter.Add(fto);
            }
            return ListFooter;
        }

        public FooterObject GetByID(Guid id)
        {
            var listFooterDb = db.SP_Footers_GetByFooterID(id);
            FooterObject fto = new FooterObject();
            foreach (var item in listFooterDb)
            {
                fto.FooterID = item.FooterID;
                fto.FooterName = item.FooterName;
            }
            return fto;
        }

        public void Update(FooterObject entity)
        {
            db.SP_Footers_UPDATE(entity.FooterID, entity.FooterName);
        }
    }
}