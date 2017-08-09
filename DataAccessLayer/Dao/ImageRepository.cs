using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
  

    public class ImageRepository 
    {
        private DataModel.furniShopEntities db = new furniShopEntities();
        public ImageObject Add(ImageObject entity)
        {
            db.SP_Images_INSERT(entity.ImageID, entity.URL, entity.BannerFlag,entity.LogoFlag);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Images_DELETE(id);
        }

        public List<ImageObject> GetAll(string[] includes = null)
        {
            var listImageDb = db.SP_Images_GetAll();
            List<ImageObject> ListImage = new List<ImageObject>();
            foreach (var item in listImageDb)
            {
                ImageObject imo = new ImageObject();
                imo.ImageID = item.ImageID;
                imo.URL = item.URL;
                imo.LogoFlag = item.LogoFlag;
                ListImage.Add(imo);
            }
            if (ListImage != null)
            {
                return ListImage;
            }
            else return null;
        }

        public ImageObject GetByID(Guid id)
        {
            var listImageDb = db.SP_Images_GetByImageID(id);
            ImageObject imo = new ImageObject();
            foreach (var item in listImageDb)
            {
                imo.ImageID = item.ImageID;
                imo.URL = item.URL;
                imo.LogoFlag = item.LogoFlag;
            }
            return imo;
        }

        public string GetURLLogoRepo()
        {
            var listima = db.SP_Images_GetAll();
            foreach (var item in listima)
            {
                if (item.LogoFlag == true)
                {
                    string url = item.URL;
                    return url;
                }
            }
            return null;
        }

        public void Update(ImageObject entity)
        {
            db.SP_Images_UPDATE(entity.ImageID, entity.URL, entity.BannerFlag,entity.LogoFlag);
        }
    }
}