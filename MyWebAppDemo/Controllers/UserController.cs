using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic;
using MyWebAppDemo.Data;
using MyWebAppDemo.Models;

namespace MyWebAppDemo.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<userModel> users = _context.Users;
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(userModel UsersModel)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(UsersModel);
                _context.SaveChanges();
                TempData["success"] = "user create done !";
                return RedirectToAction("Index");
            }
            return View(UsersModel);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var userData = _context.Users.Find(id);
            if(userData == null)
            {
                return NotFound();
            }
            return View(userData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(userModel UsersModel)
        {

            if (ModelState.IsValid)
            {
                _context.Users.Update(UsersModel);
                _context.SaveChanges();
                TempData["success"] = "user update done !";
                return RedirectToAction("Index");
            }
            return View(UsersModel);
    
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var userId = _context.Users.Find(id);
                if(userId == null)
            {
                NotFound();
            }
            _context.Users.Remove(userId);
            _context.SaveChanges();
            TempData["success"] = "user delete done";
            return RedirectToAction("Index");
        }

    }
}
