using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class DoctorBCL
    {
        public List<DoctorObject> Doctor_GetAll()
        {
            return new DoctorDao().BS_GetAll();
        }

        public DoctorObject Doctor_GetById(Guid id)
        {
            return new DoctorDao().Get_ByID(id);
        }

        public void Doctor_Insert(DoctorObject dto)
        {
            new DoctorDao().BS_Insert(dto);
        }

        public void Doctor_update(DoctorObject dto)
        {
            new DoctorDao().BS_Update(dto);
        }

        public void Doctor_Delete(Guid id)
        {
            new DoctorDao().BS_Delete(id);
        }
    }
}