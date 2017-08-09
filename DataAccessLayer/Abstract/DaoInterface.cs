using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface DaoInterface<T> where T:class
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        List<T> GetAll(string[] includes=null);
        T GetByID(Guid id);
     
       


    }
}
