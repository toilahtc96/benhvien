using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IUserRepository : DaoInterface<UserObject> { }

    public class UserRepository : IUserRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public UserObject Add(UserObject entity)
        {
            db.SP_Users_INSERT(entity.UserID, entity.FirstName, entity.LastName, entity.Email, entity.PassWord, entity.Mobile, entity.Address, entity.RoleID);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Users_DELETE(id);
        }

        public List<UserObject> GetAll(string[] includes = null)
        {
            var listUserDb = db.SP_Users_GetAll();
            List<UserObject> ListUser = new List<UserObject>();
            foreach (var item in listUserDb)
            {
                UserObject uso = new UserObject();
                uso.UserID = item.UserID;
                uso.FirstName = item.FirstName;
                uso.LastName = item.LastName;
                uso.Email = item.Email;
                uso.PassWord = item.PassWord;
                uso.Mobile = item.Mobile;
                uso.Address = item.Address;
                uso.RoleID = item.RoleID;
                ListUser.Add(uso);
            }
            return ListUser;
        }

        public UserObject GetByID(Guid id)
        {
            var listUserDb = db.SP_Users_GetByUserID(id);
            UserObject uso = new UserObject();
            foreach (var item in listUserDb)
            {
                uso.UserID = item.UserID;
                uso.FirstName = item.FirstName;
                uso.LastName = item.LastName;
                uso.Email = item.Email;
                uso.PassWord = item.PassWord;
                uso.Mobile = item.Mobile;
                uso.Address = item.Address;
                uso.RoleID = item.RoleID;
            }
            return uso;
        }

        public void Update(UserObject entity)
        {
            db.SP_Users_UPDATE(entity.UserID, entity.FirstName, entity.LastName, entity.Email, entity.PassWord, entity.Mobile, entity.Address, entity.RoleID);
        }
    }
}