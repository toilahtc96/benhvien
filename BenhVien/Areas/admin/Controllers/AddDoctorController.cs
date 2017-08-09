using System;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class AddDoctorController : Controller
    {
        private DoctorBCL dtb = new DoctorBCL();

        // GET: admin/AddDoctor
        public ActionResult AdddtView()
        {
            DoctorObject dto = new DoctorObject();

            return View(dto);
        }

        [HttpPost]
        public ActionResult RedirectToAdmin(DoctorObject dto)
        {
            Guid id = new Guid();
            dto.ID = id;
            string Imagedt = Models.SaveImage.TrySaveFileAndGetUrl("Images", this);
            dto.Images = Imagedt;
            if (ModelState.IsValid)
            {
                dtb.Doctor_Insert(dto);
                return RedirectToAction("DoctorAdminView", "Doctor");
            }
            return RedirectToAction("AdddtView", "AddDoctor");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("DoctorAdminView", "Doctor");
        }
    }
}