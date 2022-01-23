using IDSC_Task.Core;
using IDSC_Task.Core.Interfaces;
using IDSC_Task.Core.Models;
using IDSC_Task.EF;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IDSC_Task.Controllers
{
    public class NewsController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public NewsController(IUnitOfWork unitOfWork)
        {
             _unitOfWork= unitOfWork;
        }


        public IActionResult Index()
        {
            ViewData["CategoryData"] = _unitOfWork.Category.GetAll();
            return View(_unitOfWork.News.GetAll()); 
        }

       




    }
}
