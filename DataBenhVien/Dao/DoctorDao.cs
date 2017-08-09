using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class DoctorDao
    {
        private DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<DoctorObject> BS_GetAll()
        {
            var listdb = db.SP_Doctors_GetAll();
            List<DoctorObject> listDoctor = new List<DoctorObject>();
            foreach (var item in listdb)
            {
                DoctorObject dt = new DoctorObject();
                dt.Name = item.Name;
                dt.Description = item.Description;
                dt.ID = item.ID;
                dt.IDKhoa = item.IDkhoa;
                dt.MedicalName = item.MedicalName;
                dt.Status = item.Status;
                dt.Images = item.Images;
                listDoctor.Add(dt);
            }
            return listDoctor;
        }

        public DoctorObject Get_ByID(Guid id)
        {
            DoctorObject dto = new DoctorObject();
            var list = db.SP_Doctors_GetByID(id);
            foreach (var item in list)
            {
                dto.ID = item.ID;
                dto.IDKhoa = item.IDkhoa;
                dto.Images = item.Images;
                dto.MedicalName = item.MedicalName;
                dto.Name = item.Name;
                dto.Status = item.Status;
                dto.Description = item.Description;
            }
            return dto;
        }

        public void BS_Insert(DoctorObject dt)
        {
            dt.ID = Guid.NewGuid();
            db.SP_Doctors_INSERT(dt.ID, dt.Name, dt.Images, dt.Description, dt.Status, dt.MedicalName, dt.IDKhoa);
        }

        public void BS_Update(DoctorObject dt)
        {
            db.SP_Doctors_UPDATE(dt.ID, dt.Name, dt.Images, dt.Description, dt.Status, dt.MedicalName, dt.IDKhoa);
        }

        public void BS_Delete(Guid id)
        {
            db.SP_Doctors_DELETE(id);
        }
    }
}