using IDSC_Task.Core.Interfaces;
using IDSC_Task.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.EF.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly ApplicationDbContext _context;
        public NewsRepository(ApplicationDbContext context):base(context)
        {    
            //here special methods for news only************** 

        }

    }
}
