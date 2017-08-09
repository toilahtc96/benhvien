using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IRoleRepository : DaoInterface<RoleObject> { }

    public class RoleRepository : IRoleRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public RoleObject Add(RoleObject entity)
        {
            db.SP_Roles_INSERT(entity.RoleID, entity.RoleName);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Roles_DELETE(id);
        }

        public List<RoleObject> GetAll(string[] includes = null)
        {
            var listRoleDb = db.SP_Roles_GetAll();
            List<RoleObject> ListRole = new List<RoleObject>();
            foreach (var item in listRoleDb)
            {
                RoleObject ro = new RoleObject();
                ro.RoleID = item.RoleID;
                ro.RoleName = item.RoleName;
                ListRole.Add(ro);
            }
            return ListRole;
        }

        public RoleObject GetByID(Guid id)
        {
            var listRoleDb = db.SP_Roles_GetByRoleID(id);
            RoleObject ro = new RoleObject();
            foreach (var item in listRoleDb)
            {
                ro.RoleID = item.RoleID;
                ro.RoleName = item.RoleName;
            }
            return ro;
        }

        public void Update(RoleObject entity)
        {
            db.SP_Roles_UPDATE(entity.RoleID, entity.RoleName);
        }
    }
}