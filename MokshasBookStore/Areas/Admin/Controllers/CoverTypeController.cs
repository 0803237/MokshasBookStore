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
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitofWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            CoverType coverType = new CoverType();
            if (id == null)
            {
                return View(coverType);
            }

            coverType = _unitofWork.CoverType.Get(id.GetValueOrDefault());
            if (coverType == null)
            {
                return NotFound(coverType);
            }
            return View(coverType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {

            if (ModelState.IsValid)
            {
                if (coverType.Id == 0)
                {
                    _unitofWork.CoverType.Add(coverType);
                    _unitofWork.Save();
                }
                else
                {
                    _unitofWork.CoverType.Update(coverType);
                }
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(coverType);
        }

        // API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allObj = _unitofWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitofWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = true, message = "Erroe while Deleting" });
            }
            _unitofWork.CoverType.Remove(objFromDb);
            _unitofWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
            #endregion
        }
    }
}
