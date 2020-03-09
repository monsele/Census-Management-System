using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CensusManagement_System.Models;
using CensusManagement_System.Services;
using CensusManagement_System.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CensusManagement_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IState state;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IState state)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.state = state;
        }
        public IActionResult Index()
        {
            var res = userManager.Users.ToList();
            return View(res);
        }
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            model.States = state.GetStates();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName=model.BVN,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    State = state.GetState(model.StateId),
                    BVN=model.BVN,
                    DateOfBirth=model.DateOfBirth,
                    IsInCountry=model.IsInCountry
                };
                var result = await userManager.CreateAsync(user,model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                var error = result.Errors;
                return View(error.ToList());
            }
            RegisterViewModel rmodel = new RegisterViewModel();
            rmodel.States = state.GetStates();
            return View(rmodel);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
                if (result.Succeeded)
                {
                    //logger.LogInformation("User Just Logged in");
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            // logger.LogInformation("User Logged out");
            return RedirectToAction("Login");
        }

    }
}