using FinalAgain.DAL;
using FinalAgain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalAgain.Controllers
{
    [Authorize(Roles = "Admin , HeadOfDepartment , Student")]
    public class ClassController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDBContext _context;

        public ClassController(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager,
                                      RoleManager<IdentityRole> roleManager, AppDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            List<Class> array = new List<Class>();
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var data = _context.Classes.Include(x => x.Teacher).Include(x => x.StudentClasses).ThenInclude(x=> x.Student).ToList();

            if (data.Count > 0)
            {
                var teacherName = _userManager.FindByIdAsync(data[0].TeacherId).Result;
                foreach (var i in data)
                {
                    foreach (var j in i.StudentClasses)
                    {
                        if (user.Id == j.StudentId && i.Id == j.ClassId)
                            {
                                array.Add(i);
                                break;
                            }
                    }
                }

                ViewBag.clas = data.Except(array).ToList();
                ViewBag.enrolledClasses = array;
                ViewBag.teacherNmae = teacherName;
            }
            return View();

        }

        [Authorize(Roles = "Admin, HeadOfDepartment")]

        public IActionResult Create()
        {


            ViewBag.courses = _context.typeOfCourses.ToList();

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin, HeadOfDepartment")]
        public IActionResult Create(Class data)
        {

            Class Subjects = new Class()
            {
                Name = data.Name,
                Code = data.Code,
                Credit = data.Credit,
                TypeOfCourseId = data.TypeOfCourseId
            };
            _context.Classes.Add(Subjects);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin, Student")]
        public IActionResult addStudent(int id, string userId)
        {
            var checker = _context.StudentClasses.FirstOrDefault(x => x.ClassId == id && x.StudentId == userId);


            StudentClass SC = new StudentClass()
            {
                ClassId = id,
                StudentId = userId
            };

            _context.StudentClasses.Add(SC);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }
        [Authorize(Roles = "Admin")]
        public IActionResult AddThisClass(string data, int id)
        {
            var check = _context.StudentClasses.FirstOrDefault(x => x.ClassId == id && x.StudentId == data);
            if (check == null)
            {
                StudentClass SD = new StudentClass()
                {
                    StudentId = data,
                    ClassId = id
                };
                _context.StudentClasses.Add(SD);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("addStudent");
        }
        [Authorize(Roles = "Admin, HeadOfDepartment")]
        public IActionResult addTeacher(int id)
        {
            var data = _userManager.Users.ToList().FindAll(x => _userManager.IsInRoleAsync(x, "Teacher").Result);
            if (data != null)
            {
                ViewBag.data = data;
                ViewBag.id = id;
                return View();

            }
            return RedirectToAction("Index");

        }
        [Authorize(Roles = "Admin, HeadOfDepartment")]
        public IActionResult AddThisTeacher(string data, int id)
        {
            var clas = _context.Classes.FirstOrDefault(x => x.Id == id);
            clas.TeacherId = data;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
