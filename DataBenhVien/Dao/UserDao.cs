using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class UserDao
    {
        private DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<UserObject> User_GetAll()
        {
            var us_list = db.SP_User_GetAll();
            List<UserObject> UserList = new List<UserObject>();
            foreach (var item in us_list)
            {
                UserObject uso = new UserObject();
                uso.Name = item.Name;
                uso.PassWord = item.PassWord;
                uso.UserName = item.UserName;
                UserList.Add(uso);
            }
            return UserList;
        }

        public UserObject User_GetByName(String name)
        {
            var us = db.SP_User_GetByUserName(name);
            UserObject uso = new UserObject();
            foreach (var item in us)
            {
                uso.PassWord = item.PassWord;
                uso.UserName = item.UserName;
            }
            return uso;
        }

        public void User_Update(UserObject svo)
        {
            db.SP_User_UPDATE(svo.Name, svo.UserName, svo.PassWord);
        }

        public void User_Insert(UserObject svo)
        {
            db.SP_User_INSERT(svo.Name, svo.UserName, svo.PassWord);
        }

        public void User_delele(string name)
        {
            db.SP_User_DELETE(name);
        }
    }
}