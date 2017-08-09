using System.Collections.Generic;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Controllers
{
    public class TeamDoctorController : Controller
    {
        private DoctorBCL dtb = new DoctorBCL();

        // GET: TeamDoctor
        public ActionResult Team()
        {
            List<DoctorObject> dtl = new List<DoctorObject>();
            dtl = dtb.Doctor_GetAll();
            return PartialView(dtl);
        }
    }
}