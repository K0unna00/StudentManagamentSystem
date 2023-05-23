using FinalAgain.ViewModels;
using FinalAgain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAgain.DAL;
using Microsoft.EntityFrameworkCore;

namespace FinalAgain.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDBContext _context;

        public AccountController(UserManager<IdentityUser> userManager,
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
            return View();
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateRole()
        {
            await _roleManager.CreateAsync(new IdentityRole("HeadOfDepartment"));
            return Ok();
        }

        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser admin = new AppUser()
        //    {
        //        UserName = "Admin"
        //    };
        //    var result = await _userManager.CreateAsync(admin, "Admin123!");
        //    if (!result.Succeeded)
        //    {
        //        return Ok(result.Errors);
        //    }
        //    var resultV2 = await _userManager.AddToRoleAsync(admin, "Admin");
        //    if (resultV2.Succeeded)
        //    {
        //        return Ok(result.Errors);
        //    }
        //    return Ok();
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userName = "";
                var data = _context.Users.ToList();
                foreach (var i in data)
                {
                    if (i.LoginId == user.LoginId)
                    {
                        userName = i.UserName;
                    }
                }
                var result = await _signInManager.PasswordSignInAsync(userName, user.Password, false, false);
                //_signInManager.SignInAsync()

                if (result.Succeeded)
                {
                    //var currentUserIdentity = await _userManager.FindByNameAsync(User.Identity.Name);
                    var currentUser = _context.Users.FirstOrDefault(x => x.UserName == userName);
                    if (!currentUser.isAccepted)
                    {
                        ModelState.AddModelError(string.Empty, "Admin didn't accept your enroll");
                        await _signInManager.SignOutAsync();
                        return View(user);
                    }

                    return RedirectToAction("Index", "Dashboard");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            ViewBag.Tags = _context.Roles.ToList();
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel user)
        {
            ViewBag.Tags = _context.Roles.ToList();
            if (ModelState.IsValid)
            {

                string loginIdString = user.LoginId.ToString();

                if(loginIdString.Length != 10)
                {
                    ModelState.AddModelError("LoginId", "Length must be 10");

                    return View();

                }

                var newUSer = new AppUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    LoginId = user.LoginId,
                };

                var result =  _userManager.CreateAsync(newUSer, user.Password).Result;

                

                if (result.Succeeded)
                {
                    _context.SaveChanges();

                     await _userManager.AddToRoleAsync(newUSer, user.Role);

                    return RedirectToAction("Login");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }


            }
            return View(user);
        }


        public IActionResult Requests()
        {
            var data = _context.Users.ToList().FindAll(x=> x.isAccepted == false);
            if(data.Count > 0)
            {
                ViewBag.data = data;
            }
            return View();
        }
        public IActionResult AcceptRequest(string id)
        {
            AppUser user = _context.Users.FirstOrDefault(x=> x.Id == id);
            user.isAccepted = true;
            _context.SaveChanges();

            var data = _context.Users.ToList().FindAll(x => x.isAccepted == false);
            if (data.Count > 0)
            {
                ViewBag.data = data;
            }

            return RedirectToAction("Requests");
        }
    }
}
