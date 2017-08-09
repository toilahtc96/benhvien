using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class EditMedicalController : Controller
    {
        private MedicalBCL mdb = new MedicalBCL();

        // GET: admin/EditMedical
        public ActionResult AdminMedical()
        {
            List<MedicalObject> listMdo = mdb.Medical_GetAll().ToList();
            return View(listMdo);
        }

        public ActionResult RedirectToEditMedical(MedicalObject mdo)
        {
            Guid id = mdo.ID;
            return RedirectToAction("EditMedicalView", "EditMedical", new { id = id });
        }

        public ActionResult EditMedicalView(Guid id)
        {
            MedicalObject mdo = mdb.Medical_GetById(id);
            return View(mdo);
        }

        [HttpPost]
        public ActionResult EditMedicalDone(MedicalObject mdo)
        {
            string img = Models.SaveImage.TrySaveFileAndGetUrl("Image", this);
            if (img != null)
            {
                mdo.Image = img;
            }
            mdb.Medical_Update(mdo);
            return RedirectToAction("AdminMedical", "EditMedical");
        }

        public ActionResult DeleteMedical(MedicalObject mdo)
        {
            Guid id = mdo.ID;
            mdb.Medical_Delete(id);
            return RedirectToAction("AdminMedical", "EditMedical");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("AdminMedical", "EditMedical");
        }

        public ActionResult DeleteMedical_clk(MedicalObject mdo)
        {
            return View(mdo);
        }
    }
}