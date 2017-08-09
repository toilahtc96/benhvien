using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataBenhVien.Dao
{
    public class FeedbackDao
    {
        private DataModel.benhvienEntities1 db = new DataModel.benhvienEntities1();

        public List<FeedbackObject> Feedback_GetAll()
        {
            var fb_list = db.SP_Feedbacks_GetAll();
            List<FeedbackObject> FeedbackList = new List<FeedbackObject>();
            foreach (var item in fb_list)
            {
                FeedbackObject fbo = new FeedbackObject();
                fbo.ID = item.ID;
                fbo.CrateDate = item.CreateDate;
                fbo.CustomerName = item.CustommerName;
                fbo.Email = item.Email;
                fbo.ID = item.ID;
                fbo.PhoneNumber = item.PhoneNumber;
                fbo.NoiDung = item.NoiDung;
                FeedbackList.Add(fbo);
            }
            return FeedbackList;
        }

        public FeedbackObject Feedback_GetByID(Guid id)
        {
            var fb = db.SP_Feedbacks_GetByID(id);
            FeedbackObject fbo = new FeedbackObject();
            foreach (var item in fb)
            {
                fbo.CrateDate = item.CreateDate;
                fbo.CustomerName = item.CustommerName;
                fbo.Email = item.Email;
                fbo.ID = item.ID;
                fbo.PhoneNumber = item.PhoneNumber;
                fbo.NoiDung = item.NoiDung;
            }
            return fbo;
        }

        public void Feedback_Update(FeedbackObject fbo)
        {
            db.SP_Feedbacks_UPDATE(fbo.ID, fbo.CustomerName, fbo.PhoneNumber, fbo.Email, fbo.NoiDung, fbo.CrateDate);
        }

        public void Feedback_Insert(FeedbackObject fbo)
        {
            fbo.ID = Guid.NewGuid();
            db.SP_Feedbacks_INSERT(fbo.ID, fbo.CustomerName, fbo.PhoneNumber, fbo.Email, fbo.NoiDung, fbo.CrateDate);
        }

        public void Feedback_delele(Guid id)
        {
            db.SP_Feedbacks_DELETE(id);
        }
    }
}