using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class DoctorController : Controller
    {
        private DoctorBCL dtb = new DoctorBCL();

        // GET: admin/Doctor
        public ActionResult DoctorAdminView()
        {
            List<DoctorObject> listdto = dtb.Doctor_GetAll().ToList();
            return View(listdto);
        }

        public ActionResult RedirecToDoctorEditView(DoctorObject dto)
        {
            Guid id = dto.ID;
            return RedirectToAction("EditDoctor", "Doctor", new { id = id });
        }

        public ActionResult EditDoctor(Guid id)
        {
            DoctorObject dto = dtb.Doctor_GetById(id);
            return View(dto);
        }

        [HttpPost]
        public ActionResult EditDoctorDone(DoctorObject dto)
        {
            string Imagedt = Models.SaveImage.TrySaveFileAndGetUrl("Images", this);
            if (Imagedt != null)
            {
                dto.Images = Imagedt;
            }
            dtb.Doctor_update(dto);
            return RedirectToAction("DoctorAdminView", "Doctor");
        }

        public ActionResult DeleteDoctor(DoctorObject dto)
        {
            Guid id = dto.ID;
            dtb.Doctor_Delete(id);
            return RedirectToAction("DoctorAdminView", "Doctor");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("DoctorAdminView", "Doctor");
        }

        public ActionResult DeleteDoctor_clk(DoctorObject dto)
        {
            return View(dto);
        }
    }
}