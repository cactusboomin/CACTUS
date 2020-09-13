using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> userManager;

        public UserController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
        }

        public IActionResult Index(string name)
        {
            IdentityUser user = userManager.FindByNameAsync(name).Result;

            return View(new UserViewModel(user, dataManager));
        }

        [Authorize]
        public IActionResult Settings(string name)
        {
            IdentityUser user = userManager.FindByNameAsync(name).Result;

            return View(new UserViewModel(user));
        }

        [Authorize]
        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            return View(new ChangePasswordViewModel { Id = user.Id, Email = user.Email });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.Id);

                var _passwordValidator =
                HttpContext.RequestServices.GetService(typeof(IPasswordValidator<IdentityUser>)) 
                                            as IPasswordValidator<IdentityUser>;
                var _passwordHasher =
                    HttpContext.RequestServices.GetService(typeof(IPasswordHasher<IdentityUser>)) 
                                                as IPasswordHasher<IdentityUser>;

                IdentityResult result =
                    await _passwordValidator.ValidateAsync(userManager, user, model.NewPassword);

                if (result.Succeeded)
                {
                    user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, model.NewPassword);
                    await userManager.UpdateAsync(user);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(model);
        }
    }
}
