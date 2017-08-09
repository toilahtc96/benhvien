using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IContactRepository : DaoInterface<ContactObject> { }

    public class ContactRepository : IContactRepository
    {
        private DataModel.furniShopEntities db = new DataModel.furniShopEntities();

        public ContactObject Add(ContactObject entity)
        {
            db.SP_Contacts_INSERT(entity.ContactID, entity.Name, entity.Email, entity.Phone, entity.Message, entity.CreateDate);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Contacts_DELETE(id);
        }

        public List<ContactObject> GetAll(string[] includes = null)
        {
            var listContactDb = db.SP_Contacts_GetAll();
            List<ContactObject> ListContact = new List<ContactObject>();
            foreach (var item in listContactDb)
            {
                ContactObject cto = new ContactObject();
                cto.ContactID = item.ContactID;
                cto.Name = item.Name;
                cto.Email = item.Email;
                cto.CreateDate = item.CreateDate;
                cto.Phone = item.Phone;
                cto.Message = item.Message;
                ListContact.Add(cto);
            }
            return ListContact;
        }

        public ContactObject GetByID(Guid id)
        {
            var ContactDb = db.SP_Contacts_GetByContactID(id);
            ContactObject cto = new ContactObject();

            foreach (var item in ContactDb)
            {
                cto.ContactID = item.ContactID;
                cto.CreateDate = item.CreateDate;
                cto.Email = item.Email;
                cto.Message = item.Message;
                cto.Name = item.Name;
                cto.Phone = item.Phone;
            }
            return cto;
        }

        public void Update(ContactObject entity)
        {
            db.SP_Contacts_UPDATE(entity.ContactID, entity.Name, entity.Email, entity.Phone, entity.Message, entity.CreateDate);
        }
    }
}