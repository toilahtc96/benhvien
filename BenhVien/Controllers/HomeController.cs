using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            ServiceBCL Servicebcl = new ServiceBCL();
            ServiceObject svo = new ServiceObject();
            List<ServiceObject> svl = Servicebcl.Service_GetAll();
            svo = svl.FirstOrDefault();
            return View(svo);
        }
    }
}