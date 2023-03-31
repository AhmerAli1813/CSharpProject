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
                return RedirectToAction("Index");
            }
            return View(UsersModel);
        }
    }
}
