using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class UserBCL
    {
        public List<UserObject> User_GetAll()
        {
            return new UserDao().User_GetAll();
        }

        public UserObject User_GetByUserName(string name)
        {
            return new UserDao().User_GetByName(name);
        }

        public void User_Insert(UserObject mno)
        {
            new UserDao().User_Insert(mno);
        }

        public void User_Update(UserObject mno)
        {
            new UserDao().User_Update(mno);
        }

        public void User_Delete(string userName)
        {
            new UserDao().User_delele(userName);
        }
    }
}