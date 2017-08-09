using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class LeftSideController : Controller
    {
        private MenuBCL mnb = new MenuBCL();

        // GET: admin/LeftSide
        public ActionResult MenuLeft()
        {
            MenuObject mno = new MenuObject();
            mno = mnb.Memu_GetAll().FirstOrDefault();
            return View(mno);
        }
    }
}