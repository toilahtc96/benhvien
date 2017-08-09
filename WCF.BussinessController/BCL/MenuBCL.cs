using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class MenuBCL
    {
        public List<MenuObject> Memu_GetAll()
        {
            return new MenuDao().Menu_GetAll();
        }

        public MenuObject Menu_GetById(Guid id)
        {
            return new MenuDao().Menu_GetByID(id);
        }

        public void Menu_Insert(MenuObject mno)
        {
            new MenuDao().Menu_Insert(mno);
        }

        public void Menu_Update(MenuObject mno)
        {
            new MenuDao().Menu_Update(mno);
        }

        public void Menu_Delete(Guid id)
        {
            new MenuDao().Menu_delele(id);
        }
    }
}