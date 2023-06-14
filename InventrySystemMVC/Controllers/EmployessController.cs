using ims.DataAccessLayer.Infrastructure.IRepository;
using Ims.DataAccessLayer;
using Ims.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InventrySystemMVC.Controllers
{
    public class EmployessController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public IActionResult Index()
        {
            IEnumerable<Employees> EmpData = _unitOfWork.employees.GetAll();
            return View(EmpData);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employees EmpModel)
        {
            _unitOfWork.employees.Add(EmpModel);
            _unitOfWork.Save();
            TempData["Success"] = "Employee Created Done";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            if (id == null | id<=0 )
            {
                return View();
            }
            var empData = _unitOfWork.employees.GetT(x=>x.EId==id);
            return View(empData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employees employees)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.employees.update(employees);
                _unitOfWork.Save();
                TempData["Success"] = "Employee Updated Done";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            if (id == null | id<=0 )
            {
                return View();
            }
            var empData = _unitOfWork.employees.GetT(x => x.EId == id);
            return View(empData);
        }

        public IActionResult DeleteData(int id)
        {
            if (id == null | id<=0 )
            {
                return View();
            }
            var empData = _unitOfWork.employees.GetT(x => x.EId == id);
            return View(empData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(Employees employees)
        {
            
                _unitOfWork.employees.Delete(employees);
                _unitOfWork.Save();
                TempData["Success"] = "Employees Delete Done";
                return RedirectToAction("Index");
        }
    }
}
