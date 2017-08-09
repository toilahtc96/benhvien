using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Controllers
{
    public class LienHeController : Controller
    {
        FeedBackBCL fbb = new FeedBackBCL();
        // GET: LienHe
        public ActionResult LienHeView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LienHePost(FeedbackObject fbo)
        {
            if (fbo.CustomerName == null)
            {
                ModelState.AddModelError("name", "Cần Nhập Tên");
                return RedirectToAction("Index","Home");
            }
            Guid id = Guid.NewGuid();
            fbo.ID = id;
            DateTime dt = DateTime.Now;
            fbo.CrateDate = dt;
            fbb.Feedback_Insert(fbo);
            return RedirectToAction("Index", "Home");
        }
    }
}