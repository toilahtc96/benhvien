using DataBenhVien.Dao;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace WCF.BussinessController.BCL
{
    public class FeedBackBCL
    {
        public List<FeedbackObject> Feedback_GetAll()
        {
            return new FeedbackDao().Feedback_GetAll();
        }

        public FeedbackObject Feedback_GetById(Guid id)
        {
            return new FeedbackDao().Feedback_GetByID(id);
        }

        public void Feedback_Insert(FeedbackObject fbo)
        {
            new FeedbackDao().Feedback_Insert(fbo);
        }

        public void Feedback_update(FeedbackObject fbo)
        {
            new FeedbackDao().Feedback_Update(fbo);
        }

        public void Feedback_Delete(Guid id)
        {
            new FeedbackDao().Feedback_delele(id);
        }

       
    }
}