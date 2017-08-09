using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace BenhVien.Areas.admin.Models
{
    public class SaveImage
    {
        public static string TrySaveFileAndGetUrl(string nameFile, Controller controller, string pathFolder = "/Areas/admin/Content/ImageUpload")
        {
            HttpPostedFileBase file = controller.Request.Files[nameFile];
            if (file != null && file.ContentLength > 0 && file.ContentType.Contains("image"))
            {
                string filename = DateTime.Now.ToString("ddMMyyyyhhMMss") + "_" + Path.GetFileName(file.FileName);
                string path = Path.Combine(controller.Server.MapPath("/Areas/admin/Content/ImageUpload"), filename);
                file.SaveAs(path);
                return pathFolder + "/" + filename;
            }
            return null;
        }
    }
}