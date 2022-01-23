using IDSC_Task.Core;
using IDSC_Task.Core.Interfaces;
using IDSC_Task.Core.Models;
using IDSC_Task.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        //in case using base repo only not special repo for each component 
        //public IBaseRepository<News> News { get; private set; }

        //public IBaseRepository<Category> Categories { get; private set; }

        //public IBaseRepository<Source> Sources { get; private set; }


        public INewsRepository News { get; private set; }
        public ICategoryRepository Category { get; private set; }
        
        public ISourceRepository Source { get; private set; }
        public UnitOfWork( ApplicationDbContext context)
       
        {
            _context = context;
            News = new NewsRepository(_context);
            Category = new CategoryRepository(_context);
            Source = new SourceRepository(_context);

        }
       //method to save changes to database 
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
