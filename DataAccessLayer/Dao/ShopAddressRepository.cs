using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IShopAddressRepository : DaoInterface<ShopAddressObject> { }

    public class ShopAddressRepository : IShopAddressRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ShopAddressObject Add(ShopAddressObject entity)
        {
            db.SP_ShopAddress_INSERT(entity.ShopAddressID,entity.Address);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_ShopAddress_DELETE(id);
        }

        public List<ShopAddressObject> GetAll(string[] includes = null)
        {
            var listShopAddress = db.SP_ShopAddress_GetAll();
            List<ShopAddressObject> ListShopadd = new List<ShopAddressObject>();
            foreach (var item in listShopAddress)
            {
                ShopAddressObject sao = new ShopAddressObject();
                sao.ShopAddressID = item.ShopAddressID;
                sao.Address = item.Address;
            }
            return ListShopadd;
        }

        public ShopAddressObject GetByID(Guid id)
        {
            var ShopAddress = db.SP_ShopAddress_GetByShopAddressID(id);
            ShopAddressObject sao = new ShopAddressObject();
            foreach (var item in ShopAddress)
            {
                sao.ShopAddressID = item.ShopAddressID;
                sao.Address = item.Address;
            }
            return sao;
        }

        public void Update(ShopAddressObject entity)
        {
            db.SP_ShopAddress_UPDATE(entity.ShopAddressID, entity.Address);
        }
    }
}
