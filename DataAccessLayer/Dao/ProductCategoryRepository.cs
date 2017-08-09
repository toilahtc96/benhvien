using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IProductCategoryRepository : DaoInterface<ProductCategoryObject> { }

    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ProductCategoryObject Add(ProductCategoryObject entity)
        {
            db.SP_ProductCategorys_INSERT(entity.ProductCategoryID, entity.CategoryName, entity.CategoryDescription);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_ProductCategorys_DELETE(id);
        }

        public List<ProductCategoryObject> GetAll(string[] includes = null)
        {
            var listProductCategoryDb = db.SP_ProductCategorys_GetAll();
            List<ProductCategoryObject> ListProductCategory = new List<ProductCategoryObject>();
            foreach (var item in listProductCategoryDb)
            {
                ProductCategoryObject pco = new ProductCategoryObject();
                pco.ProductCategoryID = item.ProductCategoryID;
                pco.CategoryName = item.CategoryName;
                pco.CategoryDescription = item.Description;
                ListProductCategory.Add(pco);
            }
            return ListProductCategory;
        }

        public ProductCategoryObject GetByID(Guid id)
        {
            var listProductCategoryDb = db.SP_ProductCategorys_GetByProductCategoryID(id);
            ProductCategoryObject pco = new ProductCategoryObject();
            foreach (var item in listProductCategoryDb)
            {
                pco.ProductCategoryID = item.ProductCategoryID;
                pco.CategoryName = item.CategoryName;
                pco.CategoryDescription = item.Description;
            }
            return pco;
        }

        public void Update(ProductCategoryObject entity)
        {
            db.SP_ProductCategorys_UPDATE(entity.ProductCategoryID, entity.CategoryName, entity.CategoryDescription);
        }
    }
}