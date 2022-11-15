using Microsoft.AspNetCore.Mvc;
using MokshasBooks.DataAccess.Repository.IRepository;
using MokshasBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MokshasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);
            }

            category = _unitofWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound(category);
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {

            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _unitofWork.Category.Add(category);
                    _unitofWork.Save();
                }
                else
                {
                    _unitofWork.Category.Update(category);
                }
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitofWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitofWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitofWork.Category.Remove(objFromDb);
            _unitofWork.Save();
            return Json(new { success = true, message = "Delete successfull" });
        }

        #endregion
    }
}
