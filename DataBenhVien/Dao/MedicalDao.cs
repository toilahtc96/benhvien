using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class MedicalDao
    {
        private DataBenhVien.DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<MedicalObject> Medical_GetAll()
        {
            List<MedicalObject> Medical_List = new List<MedicalObject>();
            var listMedical = db.SP_Medicals_GetAll();
            foreach (var item in listMedical)
            {
                MedicalObject mdo = new MedicalObject();
                mdo.ID = item.ID;
                mdo.Description = item.Description;
                mdo.Image = item.Images;
                mdo.Name = item.Name;
                Medical_List.Add(mdo);
            }
            return Medical_List;
        }

        public MedicalObject Medical_GetByID(Guid id)
        {
            var Media_List = db.SP_Medicals_GetByID(id);
            MedicalObject mdo = new MedicalObject();
            foreach (var item in Media_List)
            {
                mdo.ID = item.ID;
                mdo.Description = item.Description;
                mdo.Image = item.Images;
                mdo.Name = item.Name;
            }
            return mdo;
        }

        public void Medical_Insert(MedicalObject mdo)
        {
            mdo.ID = Guid.NewGuid();
            db.SP_Medicals_INSERT(mdo.ID, mdo.Name, mdo.Description, mdo.Image);
        }

        public void Medical_Update(MedicalObject mdo)
        {
            db.SP_Medicals_UPDATE(mdo.ID, mdo.Name, mdo.Description, mdo.Image);
        }

        public void Medical_Delete(Guid id)
        {
            db.SP_Medicals_DELETE(id);
        }
    }
}