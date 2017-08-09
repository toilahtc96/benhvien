using System;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class EditHeaderController : Controller
    {
        private MenuBCL mnb = new MenuBCL();

        // GET: admin/EditHeader
        public ActionResult EditMenuHeader()
        {
            MenuObject mno = mnb.Memu_GetAll().FirstOrDefault();
            return View(mno);
        }

        [HttpPost]
        public ActionResult EditMenuHeader(MenuObject mno)
        {
            Guid id = mno.ID;
            return RedirectToAction("EditMenu", "EditHeader", new { id = id });
        }

        public ActionResult EditMenu(Guid id)
        {
            MenuObject mno = mnb.Menu_GetById(id);
            return View(mno);
        }

        [HttpPost]
        public ActionResult EditDone(MenuObject mno)
        {
            mnb.Menu_Update(mno);
            return RedirectToAction("EditMenuHeader", "EditHeader");
        }

        public ActionResult Cancelbt()
        {
            return RedirectToAction("EditMenuHeader", "EditHeader");
        }
    }
}