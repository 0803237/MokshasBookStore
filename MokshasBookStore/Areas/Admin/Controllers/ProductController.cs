using Microsoft.AspNetCore.Mvc;
using MokshasBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MokshasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitofWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allObj = _unitofWork.Product.GetAll();
            return Json(new { data = allObj });
        }
        #endregion

    }
}
