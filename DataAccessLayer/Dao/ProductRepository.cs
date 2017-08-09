using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IProductRepository : DaoInterface<ProductObject> {
        decimal GetTotalPrice(List<OrderDetailObject> lODD);
    }

    public class ProductRepository : IProductRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ProductObject Add(ProductObject entity)
        {
            db.SP_Products_INSERT(entity.ProductID, entity.ProductName, entity.ProductPrice, entity.HomeFlag, entity.ProductSize, entity.Detail, entity.Sale, entity.CompanyID, entity.CategoryID);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Products_DELETE(id);
        }

        public List<ProductObject> GetAll(string[] includes = null)
        {
            var listProduct = db.SP_Products_GetAll();
            List<ProductObject> ListProduct = new List<ProductObject>();
            foreach (var item in listProduct)
            {
                ProductObject pdo = new ProductObject();
                pdo.ProductID = item.ProductID;
                pdo.CategoryID = item.CategoryID;
                pdo.Detail = item.Detail;
                pdo.CompanyID = item.CompanyID;
                pdo.HomeFlag = item.HomeFlag;
                pdo.ProductName = item.ProductName;
                pdo.ProductPrice = item.Price;
                pdo.ProductSize = item.Size;
                pdo.Sale = item.Sale;
                ListProduct.Add(pdo);
            }
            return ListProduct;
        }

        public ProductObject GetByID(Guid id)
        {
            var Product = db.SP_Products_GetByProductID(id);
            ProductObject pdo = new ProductObject();
            foreach (var item in Product)
            {
                pdo.ProductID = item.ProductID;
                pdo.CategoryID = item.CategoryID;
                pdo.Detail = item.Detail;
                pdo.CompanyID = item.CompanyID;
                pdo.HomeFlag = item.HomeFlag;
                pdo.ProductName = item.ProductName;
                pdo.ProductPrice = item.Price;
                pdo.ProductSize = item.Size;
                pdo.Sale = item.Sale;
            }
            return pdo;
        }

        public decimal GetTotalPrice(List<OrderDetailObject> lODD)
        {
            decimal total = 0;
            foreach (var item in lODD) {
                ProductObject pO = new ProductObject();
                var product = GetByID((Guid)item.ProductID);
                pO.ProductPrice = product.ProductPrice;
                total += (Decimal)(pO.ProductPrice * item.Quantity);
            }
            return total;
        }

        public void Update(ProductObject entity)
        {
            db.SP_Products_UPDATE(entity.ProductID, entity.ProductName, entity.ProductPrice, entity.HomeFlag, entity.ProductSize, entity.Detail, entity.Sale, entity.CompanyID, entity.CategoryID);
        }
    }
}