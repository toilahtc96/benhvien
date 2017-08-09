using System;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class AddEquipmentController : Controller
    {
        private EquipmentBCL eqb = new EquipmentBCL();

        // GET: admin/AddEquipment
        public ActionResult AddEquipmentView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RedirectToView(EquipmentObject eqo)
        {
            Guid id = new Guid();
            eqo.ID = id;
            string img = Models.SaveImage.TrySaveFileAndGetUrl("Image", this);
            eqo.Image = img;
            if (ModelState.IsValid)
            {
                eqb.Equip_Insert(eqo);
                return RedirectToAction("EquipmentAdminView", "EquipmentAdmin", new { id = eqo.ID });
            }
            return RedirectToAction("AddEquipmentView", "AddEquipment");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("EquipmentAdminView", "EquipmentAdmin");
        }
    }
}