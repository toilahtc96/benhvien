using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class EquipmentAdminController : Controller
    {
        private EquipmentBCL eqb = new EquipmentBCL();

        // GET: admin/EquipmentAdmin
        public ActionResult EquipmentAdminView()
        {
            List<EquipmentObject> listequip = eqb.Equipment_GetAll().ToList();
            return View(listequip);
        }

        public ActionResult RedirecToEditView(EquipmentObject eqo)
        {
            Guid id = eqo.ID;
            return RedirectToAction("RedirectoAdminView", "EquipmentAdmin", new { id = id });
        }

        public ActionResult RedirectoAdminView(Guid id)
        {
            EquipmentObject eqo = new EquipmentObject();
            eqo = eqb.Equipment_GetById(id);
            return View(eqo);
        }

        [HttpPost]
        public ActionResult EquipmentEditDone(EquipmentObject eqo)
        {
            string image = Models.SaveImage.TrySaveFileAndGetUrl("Image", this);

            if (image != null)
            {
                eqo.Image = image;
            }
            eqb.Equip_update(eqo);

            return RedirectToAction("EquipmentAdminView", "EquipmentAdmin");
        }

        public ActionResult DeleteEquipment_clk(EquipmentObject eqo)
        {
            return View(eqo);
        }

        public ActionResult DeleteEquipment(EquipmentObject eqo)
        {
            Guid id = eqo.ID;
            eqb.Equip_Delete(id);
            return RedirectToAction("EquipmentAdminView", "EquipmentAdmin");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("EquipmentAdminView", "EquipmentAdmin");
        }
    }
}