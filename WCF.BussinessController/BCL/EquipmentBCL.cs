using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class EquipmentBCL
    {
        public List<EquipmentObject> Equipment_GetAll()
        {
            return new EquipmentDao().Equipment_GetAll();
        }

        public EquipmentObject Equipment_GetById(Guid id)
        {
            return new EquipmentDao().Equip_GetByID(id);
        }

        public void Equip_Insert(EquipmentObject eqo)
        {
            new EquipmentDao().Equip_Insert(eqo);
        }

        public void Equip_update(EquipmentObject dto)
        {
            new EquipmentDao().Equip_Update(dto);
        }

        public void Equip_Delete(Guid id)
        {
            new EquipmentDao().Equip_delele(id);
        }
    }
}