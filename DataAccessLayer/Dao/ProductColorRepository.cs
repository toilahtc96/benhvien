using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IProductColorRepository : DaoInterface<ProductColorObject> { }

    public class ProductColorRepository : IProductColorRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ProductColorObject Add(ProductColorObject entity)
        {
            db.SP_ProductColors_INSERT(entity.ProductColorID, entity.ColorID, entity.ProductID);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_ProductColors_DELETE(id);
        }

        public List<ProductColorObject> GetAll(string[] includes = null)
        {
            var listProductColor = db.SP_ProductColors_GetAll();
            List<ProductColorObject> ListProductColor = new List<ProductColorObject>();
            foreach (var item in listProductColor)
            {
                ProductColorObject pco = new ProductColorObject();
                pco.ProductColorID = item.ProductColorID;
                pco.ColorID = item.ColorID;
                pco.ProductID = item.ProductID;
                ListProductColor.Add(pco);
            }
            return ListProductColor;
        }

        public ProductColorObject GetByID(Guid id)
        {
            var listProductColor = db.SP_ProductColors_GetByProductColorID(id);
            ProductColorObject pco = new ProductColorObject();
            foreach (var item in listProductColor)
            {
                pco.ProductColorID = item.ProductColorID;
                pco.ColorID = item.ColorID;
                pco.ProductID = item.ProductID;
            }
            return pco;
        }

        public void Update(ProductColorObject entity)
        {
            db.SP_ProductColors_UPDATE(entity.ProductColorID, entity.ColorID, entity.ProductID);
        }
    }
}