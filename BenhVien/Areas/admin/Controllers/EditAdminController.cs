using System.Linq;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class EditAdminController : Controller
    {
        private ServiceBCL svb = new ServiceBCL();

        // GET: admin/EditAdmin
        public ActionResult EditHomePage()
        {
            ServiceObject svo = new ServiceObject();
            svo = svb.Service_GetAll().FirstOrDefault();
            return View(svo);
        }

        [HttpPost]
        public ActionResult EditHomePage(ServiceObject svo)
        {
            string image = Models.SaveImage.TrySaveFileAndGetUrl("Image", this);
            if (image != null)
            {
                svo.Image = image;
            }
            string bg = Models.SaveImage.TrySaveFileAndGetUrl("BackGround", this);
            if (bg != null)
            {
                svo.BackGround = bg;
            }
            string lg = Models.SaveImage.TrySaveFileAndGetUrl("LogoImage", this);
            if (lg != null)
            {
                svo.LogoImage = lg;
            }
            svb.Service_Update(svo);
            return RedirectToAction("EditHomePage", "EditAdmin");
        }
    }
}