using ims.DataAccessLayer.Infrastructure.IRepository;
using Ims.Models.ViewModels;
using Ims.DataAccessLayer;
using Ims.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InventrySystemMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployessController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public IActionResult Index()
        {
            EmpView Employeess = new EmpView();
            Employeess.EmpList = _unitOfWork.employees.GetAll();
            return View(Employeess);
        }
        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Employees EmpModel)
        //{
        //    _unitOfWork.employees.Add(EmpModel);
        //    _unitOfWork.Save();
        //    TempData["Success"] = "Employee Created Done";
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpGet]
        public IActionResult CreateUpdate(int? id)
        {
            EmpView EmpModels = new EmpView();
            if (id==null | id == 0)
            {
                return View(EmpModels.employees);
            }
            else
            {
                EmpModels.employees= _unitOfWork.employees.GetT(x => x.EId == id);
                if(EmpModels.employees == null)
                {
                    return NotFound();
                }
                else { return View(EmpModels); }
                
            }
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUpdate(EmpView empModelVW)
        {
            if (ModelState.IsValid)
            {
                if(empModelVW.employees.EId == 0 )
                {
                    _unitOfWork.employees.Add(empModelVW.employees);
                    TempData["Success"] = "Employee create Done";
                }
                else
                {
                    _unitOfWork.employees.update(empModelVW.employees);
                    TempData["Success"] = "Employee Updated Done";
                }
                
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            EmpView emp = new EmpView();
            if (id == null | id <= 0)
            {
                return View(emp);
            }
             emp.employees = _unitOfWork.employees.GetT(x => x.EId == id);
            return View(emp);
        }

        public IActionResult DeleteData(int? id)
        {
            EmpView emp = new EmpView();
            if (id == null | id <= 0)
            {
                return View();
            }
            emp.employees = _unitOfWork.employees.GetT(x => x.EId == id);
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(EmpView emp)
        {

            _unitOfWork.employees.Delete(emp.employees);
            _unitOfWork.Save();
            TempData["Success"] = "Employees Delete Done";
            return RedirectToAction("Index");
        }
    }
}
