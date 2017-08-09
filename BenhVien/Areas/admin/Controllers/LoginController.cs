using System;
using System.Web.Mvc;
using WCF.BussinessController.BCL;
using WCF.BussinessObject.EntityObject;

namespace BenhVien.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        private UserBCL usb = new UserBCL();

        // GET: admin/Login
        public ActionResult Login()
        {
            if (TempData["Error"] != null)
                ViewBag.Error = TempData["Error"].ToString();
            return View();
        }

        [HttpPost]
        public ActionResult CheckLogin(UserObject uso)
        {
            UserObject user = usb.User_GetByUserName(uso.UserName);
            if (user == null || user.PassWord != uso.PassWord)
            {
                TempData["Error"] = "Bạn Đăng Nhập Chưa Đúng";
                return RedirectToAction("Login");
            }
            else
            {
                Session["UserName"] = uso.UserName;
                Response.Cookies["UserName"].Value = uso.UserName;
                Response.Cookies["PassWord"].Value = uso.PassWord;
                Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(1);
                return RedirectToAction("EditMenuHeader", "EditHeader");
            }
        }
    }
}