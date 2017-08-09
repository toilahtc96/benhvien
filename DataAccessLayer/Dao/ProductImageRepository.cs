using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IProductImageRepository : DaoInterface<ProductImageObject> { }

    public class ProductImageRepository : IProductImageRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ProductImageObject Add(ProductImageObject entity)
        {
            db.SP_ProductImages_INSERT(entity.ImageID, entity.ProductID, entity.URL);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_ProductImages_DELETE(id);
        }

        public List<ProductImageObject> GetAll(string[] includes = null)
        {
            var listProductImageDb = db.SP_ProductImages_GetAll();
            List<ProductImageObject> ListProductImage = new List<ProductImageObject>();
            foreach (var item in listProductImageDb)
            {
                ProductImageObject pio = new ProductImageObject();
                pio.ImageID = item.ImageProductID;
                pio.ProductID = item.ProductID;
                pio.URL = item.URL;
                ListProductImage.Add(pio);
            }
            return ListProductImage;
        }

        public ProductImageObject GetByID(Guid id)
        {
            var ProductImageDb = db.SP_ProductImages_GetByImageProductID(id);
            ProductImageObject pio = new ProductImageObject();
            foreach (var item in ProductImageDb)
            {
                pio.ImageID = item.ImageProductID;
                pio.ProductID = item.ProductID;
                pio.URL = item.URL;
            }
            return pio;
        }

        public void Update(ProductImageObject entity)
        {
            db.SP_ProductImages_UPDATE(entity.ImageID, entity.ProductID, entity.URL);
        }
    }
}