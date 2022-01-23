using IDSC_Task.Core;
using Microsoft.AspNetCore.Mvc;

namespace IDSC_Task.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
          
            return View(_unitOfWork.Category.GetAll());
         
        }
       
    }
}
