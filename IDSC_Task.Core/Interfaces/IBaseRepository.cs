using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        //return data by id 
        T GetById(int id);

        //return all data 
        IEnumerable<T> GetAll();

       
        //add method
        T Add (T entity);
        //add range method
        IEnumerable<T> AddRange(IEnumerable<T> entities);

        T Update (T entity);
        void Delete(T entity);
        void Attatch(T entity);

        int Count();
        


        

    }
}
