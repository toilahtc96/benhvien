using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class MenuDao
    {
        private DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<MenuObject> Menu_GetAll()
        {
            var menu_list = db.SP_Menu_GetAll();
            List<MenuObject> MenuList = new List<MenuObject>();
            foreach (var item in menu_list)
            {
                MenuObject mno = new MenuObject();
                mno.ID = item.ID;
                mno.MenuItem1 = item.MenuItem1;
                mno.MenuItem2 = item.MenuItem2;
                mno.MenuItem3 = item.MenuItem3;
                mno.MenuItem4 = item.MenuItem4;
                mno.MenuItem5 = item.MenuItem5;
                mno.MenuItem6 = item.MenuItem6;
                MenuList.Add(mno);
            }
            return MenuList;
        }

        public MenuObject Menu_GetByID(Guid id)
        {
            var menu = db.SP_Menu_GetByID(id);
            MenuObject mno = new MenuObject();
            foreach (var item in menu)
            {
                mno.ID = item.ID;
                mno.MenuItem1 = item.MenuItem1;
                mno.MenuItem2 = item.MenuItem2;
                mno.MenuItem3 = item.MenuItem3;
                mno.MenuItem4 = item.MenuItem4;
                mno.MenuItem5 = item.MenuItem5;
                mno.MenuItem6 = item.MenuItem6;
            }
            return mno;
        }

        public void Menu_Update(MenuObject mno)
        {
            db.SP_Menu_UPDATE(mno.ID, mno.MenuItem1, mno.MenuItem2, mno.MenuItem3, mno.MenuItem4, mno.MenuItem5, mno.MenuItem6);
        }

        public void Menu_Insert(MenuObject mno)
        {
            mno.ID = Guid.NewGuid();
            db.SP_Menu_INSERT(mno.ID, mno.MenuItem1, mno.MenuItem2, mno.MenuItem3, mno.MenuItem4, mno.MenuItem5, mno.MenuItem6);
        }

        public void Menu_delele(Guid id)
        {
            db.SP_Menu_DELETE(id);
        }
    }
}