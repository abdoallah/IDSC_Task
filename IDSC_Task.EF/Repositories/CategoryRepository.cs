using IDSC_Task.Core.Interfaces;
using IDSC_Task.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.EF.Repositories
{
    public class CategoryRepository:BaseRepository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            //here special methods for catergory only ************
        }
    }
}
