using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IMenuGroupRepository : DaoInterface<MenuGroupObject> { }

    public class MenuGroupRepository : IMenuGroupRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public MenuGroupObject Add(MenuGroupObject entity)
        {
            db.SP_MenuGroups_INSERT(entity.MenuGroupID, entity.MenuGroupName);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_MenuGroups_DELETE(id);
        }

        public List<MenuGroupObject> GetAll(string[] includes = null)
        {
            var listMenuGroupDb = db.SP_MenuGroups_GetAll();
            List<MenuGroupObject> ListMenuGroup = new List<MenuGroupObject>();
            foreach (var item in listMenuGroupDb)
            {
                MenuGroupObject mgo = new MenuGroupObject();
                mgo.MenuGroupID = item.MenuGroupID;
                mgo.MenuGroupName = item.MenuGroupName;
                ListMenuGroup.Add(mgo);
            }
            return ListMenuGroup;
        }

        public MenuGroupObject GetByID(Guid id)
        {
            var listMenuGroupDb = db.SP_MenuGroups_GetByMenuGroupID(id);
            MenuGroupObject mgo = new MenuGroupObject();
            foreach (var item in listMenuGroupDb)
            {
                mgo.MenuGroupID = item.MenuGroupID;
                mgo.MenuGroupName = item.MenuGroupName;
            }
            return mgo;
        }

        public void Update(MenuGroupObject entity)
        {
            db.SP_MenuGroups_UPDATE(entity.MenuGroupID, entity.MenuGroupName);
        }
    }
}