using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface ITagRepository : DaoInterface<TagObject> { }

    public class TagRepository : ITagRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public TagObject Add(TagObject entity)
        {
            db.SP_Tags_INSERT(entity.TagID, entity.TagName, entity.TagType);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Tags_DELETE(id);
        }

        public List<TagObject> GetAll(string[] includes = null)
        {
            var listTagDb = db.SP_Tags_GetAll();
            List<TagObject> ListTag = new List<TagObject>();
            foreach (var item in listTagDb)
            {
                TagObject to = new TagObject();
                to.TagID = item.TagID;
                to.TagName = item.TagName;
                to.TagType = item.Type;
            }
            return ListTag;
        }

        public TagObject GetByID(Guid id)
        {
            var listTagDb = db.SP_Tags_GetByTagID(id);
            TagObject to = new TagObject();
            foreach (var item in listTagDb)
            {
                to.TagID = item.TagID;
                to.TagName = item.TagName;
                to.TagType = item.Type;
            }
            return to;
        }

        public void Update(TagObject entity)
        {
            db.SP_Tags_UPDATE(entity.TagID, entity.TagName, entity.TagType);
        }
    }
}