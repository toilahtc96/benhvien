using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IProductTagRepository : DaoInterface<ProductTagObject>
    {
    }

    public class ProductTagRepository : IProductTagRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ProductTagObject Add(ProductTagObject entity)
        {
            db.SP_ProductTags_INSERT(entity.ProductTagID, entity.ProductID, entity.tagID);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_ProductTags_DELETE(id);
        }

        public List<ProductTagObject> GetAll(string[] includes = null)
        {
            var listProductTagDb = db.SP_ProductTags_GetAll();
            List<ProductTagObject> ListProductTag = new List<ProductTagObject>();
            foreach (var item in listProductTagDb)
            {
                ProductTagObject pto = new ProductTagObject();
                pto.ProductID = item.ProductID;
                pto.ProductTagID = item.ProductTagID;
                pto.tagID = item.TagID;
                ListProductTag.Add(pto);
            }
            return ListProductTag;
        }

        public ProductTagObject GetByID(Guid id)
        {
            var listProductTagDb = db.SP_ProductTags_GetByProductTagID(id);
            ProductTagObject pto = new ProductTagObject();
            foreach (var item in listProductTagDb)
            {
                pto.ProductID = item.ProductID;
                pto.ProductTagID = item.ProductTagID;
                pto.tagID = item.TagID;
            }
            return pto;
        }

        public void Update(ProductTagObject entity)
        {
            db.SP_ProductTags_UPDATE(entity.ProductTagID, entity.ProductID, entity.tagID);
        }
    }
}