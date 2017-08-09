using System.Web.Mvc;

namespace BenhVien.Areas.admin.Controllers
{
    public class HomeAdmController : Controller
    {
        // GET: admin/HomeAdm
        public ActionResult AdminIndex()
        {
            return View();
        }
    }
}