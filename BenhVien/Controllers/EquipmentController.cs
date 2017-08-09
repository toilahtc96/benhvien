using System.Web.Mvc;
using WCF.BussinessController.BCL;

namespace BenhVien.Controllers
{
    public class EquipmentController : Controller
    {
        private EquipmentBCL EquipBcl = new EquipmentBCL();

        // GET: Equipment
        public ActionResult EquipmentView()
        {
            var ListEquipment = EquipBcl.Equipment_GetAll();
            return PartialView(ListEquipment);
        }
    }
}