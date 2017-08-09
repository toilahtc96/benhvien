using System;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class AddMedicalController : Controller
    {
        private MedicalBCL mdb = new MedicalBCL();

        // GET: admin/AddMedical
        public ActionResult AddMedicalView()
        {
            MedicalObject mdo = new MedicalObject();
            return View(mdo);
        }

        [HttpPost]
        public ActionResult RedirectToView(MedicalObject mdo)
        {
            Guid id = new Guid();
            mdo.ID = id;
            string img = Models.SaveImage.TrySaveFileAndGetUrl("Image", this);
            if (img != null)
            {
                mdo.Image = img;
            }
            if (ModelState.IsValid)
            {
                mdb.Medical_Insert(mdo);
                return RedirectToAction("AdminMedical", "EditMedical");
            }
            return RedirectToAction("AddMedicalView", "AddMedical");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("AdminMedical", "EditMedical");
        }
    }
}