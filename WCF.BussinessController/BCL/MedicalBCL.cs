using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class MedicalBCL
    {
        public List<MedicalObject> Medical_GetAll()
        {
            return new MedicalDao().Medical_GetAll();
        }

        public MedicalObject Medical_GetById(Guid id)
        {
            return new MedicalDao().Medical_GetByID(id);
        }

        public void Medical_Insert(MedicalObject mdo)
        {
            new MedicalDao().Medical_Insert(mdo);
        }

        public void Medical_Update(MedicalObject mdo)
        {
            new MedicalDao().Medical_Update(mdo);
        }

        public void Medical_Delete(Guid id)
        {
            new MedicalDao().Medical_Delete(id);
        }
    }
}