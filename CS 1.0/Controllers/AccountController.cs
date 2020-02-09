using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_1._0.Models;
using CS_1._0.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS_1._0.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        
        // GET: /<controller>/
        public AccountController(UserManager<User> userManaager, SignInManager<User> signInManager)
        {
            _userManager = userManaager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email, Year = model.Year };
                var result = await _userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("List", "Record");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var res = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if(res.Succeeded)
            {
                if(!string.IsNullOrEmpty(model.ReturnUrl)&&Url.IsLocalUrl(model.ReturnUrl))
                {
                    return RedirectToAction("List", "Record");
                }
                else { return RedirectToAction("List", "Record"); }
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("List", "Record");
        }
    }
}
