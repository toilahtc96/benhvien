using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IMenuItemRepository : DaoInterface<MenuItemObject> { }

    public class MenuItemRepository : IMenuItemRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public MenuItemObject Add(MenuItemObject entity)
        {
            db.SP_MenuItems_INSERT(entity.MenuGroupID, entity.MenuItemName, entity.Position, entity.URL, entity.MenuGroupID);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_MenuItems_DELETE(id);
        }

        public List<MenuItemObject> GetAll(string[] includes = null)
        {
            var listMenuItemDb = db.SP_MenuItems_GetAll();
            List<MenuItemObject> ListMenuItem = new List<MenuItemObject>();
            foreach (var item in listMenuItemDb)
            {
                MenuItemObject mio = new MenuItemObject();
                mio.MenuItemID = item.MenuItemID;
                mio.MenuItemName = item.MenuItemName;
                mio.Position = item.Position;
                mio.URL = item.URL;
                mio.MenuGroupID = item.GroupID;
                ListMenuItem.Add(mio);
            }
            return ListMenuItem;
        }

        public MenuItemObject GetByID(Guid id)
        {
            var listMenuItemDb = db.SP_MenuItems_GetByMenuItemID(id);
            MenuItemObject mio = new MenuItemObject();
            foreach (var item in listMenuItemDb)
            {
                mio.MenuItemID = item.MenuItemID;
                mio.MenuItemName = item.MenuItemName;
                mio.Position = item.Position;
                mio.URL = item.URL;
                mio.MenuGroupID = item.GroupID;
            }
            return mio;
        }

        public void Update(MenuItemObject entity)
        {
            db.SP_MenuItems_UPDATE(entity.MenuGroupID, entity.MenuItemName, entity.Position, entity.URL, entity.MenuGroupID);
        }
    }
}