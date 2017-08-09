using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IColorRepository : DaoInterface<ColorObject>
    {
    }

    public class ColorRepository : IColorRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public ColorObject Add(ColorObject entity)
        {
            db.SP_Colors_INSERT(entity.ColorID, entity.ColorName);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Colors_DELETE(id);
        }

        public List<ColorObject> GetAll(string[] includes = null)
        {
            var listColorDb = db.SP_Colors_GetAll();
            List<ColorObject> ListColor = new List<ColorObject>();
            foreach (var item in listColorDb)
            {
                ColorObject clo = new ColorObject();
                clo.ColorID = item.ColorID;
                clo.ColorName = item.ColorName;
                ListColor.Add(clo);
            }
            return ListColor;
        }

        public ColorObject GetByID(Guid id)
        {
            var cldb = db.SP_Colors_GetByColorID(id);
            ColorObject clo = new ColorObject();
            if (cldb == null)
            {
                return null;
            }
            else
            {
                foreach (var item in cldb)
                {
                    clo.ColorID = item.ColorID;
                    clo.ColorName = item.ColorName;
                }
            }
            return clo;
        }

        public void Update(ColorObject entity)
        {
            db.SP_Colors_UPDATE(entity.ColorID, entity.ColorName);
        }
    }
}