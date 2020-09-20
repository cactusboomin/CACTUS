using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CACTUS.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public UserController(DataManager dataManager, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            IdentityUser user = userManager.GetUserAsync(HttpContext.User).Result;
            
            return View(new UserViewModel(user, dataManager));
        }

        [Authorize]
        public IActionResult Settings()
        {
            IdentityUser user = userManager.GetUserAsync(HttpContext.User).Result;

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

        [Authorize]
        public async Task<IActionResult> ChangeEmail(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            return View(new ChangeEmailViewModel { Id = user.Id });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangeEmail(ChangeEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.Id);
                var checkEmail = await userManager.FindByEmailAsync(model.NewEmail);
                if (checkEmail == null)
                {
                    await userManager.SetEmailAsync(user, model.NewEmail);

                    await signInManager.SignOutAsync();
                    await Authenticate(user);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"USER WITH EMAIL {model.NewEmail} ALREADY EXISTS.");
                    return View(model);
                }
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> ChangeName(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            return View(new ChangeNameViewModel { Id = user.Id });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangeName(ChangeNameViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.Id);

                await userManager.SetUserNameAsync(user, model.NewName);

                await userManager.UpdateAsync(user);

                await signInManager.SignOutAsync();
                await Authenticate(user);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "INVALID DATA");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task Authenticate(IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email)
            };

            await signInManager.SignInWithClaimsAsync(user, true, claims);
        }
    }
}
