using System.Collections.Generic;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Controllers
{
    public class BenhLyController : Controller
    {
        private MedicalBCL medicalSer = new MedicalBCL();

        // GET: BenhLy
        public ActionResult BenhLyView()
        {
            List<MedicalObject> Medical = new List<MedicalObject>();
            Medical = medicalSer.Medical_GetAll();
            return PartialView(Medical);
        }
    }
}