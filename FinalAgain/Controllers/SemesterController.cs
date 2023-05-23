using FinalAgain.DAL;
using FinalAgain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinalAgain.Controllers
{
    [Authorize(Roles = "Admin, HeadOfDepartment")]

    public class SemesterController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDBContext _context;

        public SemesterController(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager,
                                      RoleManager<IdentityRole> roleManager, AppDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
         
        public IActionResult Index()
        {
            ViewBag.data = _context.Semesters.Include(x => x.Classes).ToList();
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Semester data)
        {
            Semester semester = new Semester()
            {
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                Name = data.Name
            };
            _context.Semesters.Add(semester);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddClass(int id)
        {
            ViewBag.semester = _context.Semesters.FirstOrDefault(x => x.Id == id);
            ViewBag.classes = _context.Classes.ToList().FindAll(x => x.SemesterId != id && x.SemesterId == null);

            return View();
        }
        public IActionResult AddThisClass(int id , int dataId)
        {
            var item = _context.Classes.FirstOrDefault(x => x.Id == id);

            item.SemesterId = dataId;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
