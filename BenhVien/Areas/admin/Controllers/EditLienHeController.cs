using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class EditLienHeController : Controller
    {
        private FeedBackBCL fbb = new FeedBackBCL();

        // GET: admin/EditLienHe
        public ActionResult EditLienHe()
        {
            List<FeedbackObject> listLH = fbb.Feedback_GetAll().ToList();
            return View(listLH);
        }

        [HttpPost]
        public ActionResult RedirectToAdmin(FeedbackObject fbo)
        {
            if (fbo.CustomerName == null)
            {
                ModelState.AddModelError("name", "Cần Nhập Tên");
                return RedirectToAction("Index", "Home");
            }
            Guid id = Guid.NewGuid();
            fbo.ID = id;
            DateTime dt = DateTime.Now;
            fbo.CrateDate = dt;
            fbb.Feedback_Insert(fbo);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Cancelbtn()
        {
            return RedirectToAction("EditLienHe", "EditLienHe");
        }

        public ActionResult RedirectoEditView(FeedbackObject fbo)
        {
            Guid id = fbo.ID;
            return RedirectToAction("EditLienHeByid", "EditLienHe", new { id = id });
        }

        public ActionResult EditLienHeByid(Guid id)
        {
            FeedbackObject fbo = fbb.Feedback_GetById(id);
            return View(fbo);
        }

        [HttpPost]
        public ActionResult EditLienHeDone(FeedbackObject fbo)
        {
            fbb.Feedback_update(fbo);
            return RedirectToAction("EditLienHe", "EditLienHe");
        }

        public ActionResult DeleteLienHe_clk(FeedbackObject fbo)
        {
            return View(fbo);
        }

        public ActionResult DeleteDone(FeedbackObject fbo)
        {
            Guid id = fbo.ID;
            fbb.Feedback_Delete(id);
            return RedirectToAction("EditLienHe", "EditLienHe");
        }
    }
}