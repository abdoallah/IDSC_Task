using IDSC_Task.Core;
using Microsoft.AspNetCore.Mvc;

namespace IDSC_Task.Controllers
{
    public class SourceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SourceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Source()
        {
           
            return View();
        }
    }
}
