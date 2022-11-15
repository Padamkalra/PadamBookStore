using Microsoft.AspNetCore.Mvc;
using PadamBookStore.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadamBookStore.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;
        
        public CategoryController(IUnitOfWork unitOfWork)


        { 
          _unitOfwork = unitOfWork;

         }



    public IActionResult Index()
        {
            return View();
        }

    IActionResult View()
    {
        throw new NotImplementedException();
    }

    //APi calls here
    #region API CALLS
    [HttpGet]
    public IActionResult GetAll()
    {
            // return NOtFound();
            var allobj = _unitOfwork.Category.GetAll();
            return Json(new { data = allobj });
    }
        #endregion
    }
}
