using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Controllers
{
    public class HeaderController : Controller
    {
        private MenuBCL mnd = new MenuBCL();
        private ServiceBCL svd = new ServiceBCL();

        // GET: Header
        public ActionResult Headermenu()
        {
            MenuObject mno = new MenuObject();
            List<MenuObject> menuList = mnd.Memu_GetAll();
            mno = menuList.FirstOrDefault();
            return PartialView(mno);
        }

        public ActionResult FitstPage()
        {
            ServiceObject svo = new ServiceObject();
            List<ServiceObject> servlist = svd.Service_GetAll();
            svo = servlist.FirstOrDefault();
            return PartialView(svo);
        }
    }
}