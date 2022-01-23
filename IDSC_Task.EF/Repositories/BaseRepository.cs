using IDSC_Task.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.EF.Repositories
{

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region note 
        // 1- not all methods are in use 
        // 2- some for future usag its just crud operations
        #endregion


        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange( entities);
            _context.SaveChanges();
            return entities;
        }

        //return matched item not by id 
        public T Find(Expression<Func<T, bool>> Criteria)
        {
            
            return _context.Set<T>().SingleOrDefault(Criteria);
        }
       

        

            //return all items in selected model of <T>
            public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        //return selected item by its id in selected model of<T>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        //update method
        public T Update(T entity)
        {
            _context.Update(entity);
            return entity;

        }
        //delete method
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        //attatch method
        public void Attatch(T entity)
        {
            _context.Set<T>().Attach(entity);
        }
        //count method
       public int Count()
        {           
            return _context.Set<T>().Count();
        }

       
    }
}
