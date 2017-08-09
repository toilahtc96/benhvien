using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class EquipmentDao
    {
        private DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<EquipmentObject> Equipment_GetAll()
        {
            var euip_list = db.SP_Equipments_GetAll();
            List<EquipmentObject> EquipmentList = new List<EquipmentObject>();
            foreach (var item in euip_list)
            {
                EquipmentObject eqo = new EquipmentObject();
                eqo.Detail = item.Details;
                eqo.ID = item.ID;
                eqo.Image = item.Images;
                eqo.Name = item.Name;
                EquipmentList.Add(eqo);
            }
            return EquipmentList;
        }

        public EquipmentObject Equip_GetByID(Guid id)
        {
            var equip = db.SP_Equipments_GetByID(id);
            EquipmentObject eq = new EquipmentObject();
            foreach (var item in equip)
            {
                eq.Detail = item.Details;
                eq.ID = item.ID;
                eq.Image = item.Images;
                eq.Name = item.Name;
            }
            return eq;
        }

        public void Equip_Update(EquipmentObject eqo)
        {
            db.SP_Equipments_UPDATE(eqo.ID, eqo.Name, eqo.Detail, eqo.Image);
        }

        public void Equip_Insert(EquipmentObject eqo)
        {
            eqo.ID = Guid.NewGuid();
            db.SP_Equipments_INSERT(eqo.ID, eqo.Name, eqo.Detail, eqo.Image);
        }

        public void Equip_delele(Guid id)
        {
            db.SP_Equipments_DELETE(id);
        }
    }
}