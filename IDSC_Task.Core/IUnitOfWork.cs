using IDSC_Task.Core.Interfaces;
using IDSC_Task.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.Core
{
    public interface IUnitOfWork:IDisposable
    {
        //in case using base repo only not special repo for each component uncomment this and do some changes  

        //IBaseRepository<News> News { get; }
        //IBaseRepository<Category> Categories { get; }
        //IBaseRepository<Source> Sources { get; }

        INewsRepository News { get; }
        ISourceRepository Source { get; }
        ICategoryRepository Category { get; }
        int Complete();
    }
}
