using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class ServiceBCL
    {
        public List<ServiceObject> Service_GetAll()
        {
            return new ServiceDao().Service_GetAll();
        }

        public ServiceObject Service_GetById(Guid id)
        {
            return new ServiceDao().Service_GetByID(id);
        }

        public void Service_Insert(ServiceObject mno)
        {
            new ServiceDao().Service_Insert(mno);
        }

        public void Service_Update(ServiceObject mno)
        {
            new ServiceDao().Service_Update(mno);
        }

        public void Service_Delete(Guid id)
        {
            new ServiceDao().Service_delele(id);
        }
    }
}