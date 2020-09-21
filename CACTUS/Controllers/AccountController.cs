using CACTUS.Domain;
using CACTUS.Domain.Entities;
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
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly DataManager dataManager;
        
        public AccountController(UserManager<IdentityUser> userMgr, 
                                SignInManager<IdentityUser> signInMgr,
                                RoleManager<IdentityRole> roleMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            roleManager = roleMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    await Authenticate(user);
                    return Redirect(returnUrl ?? "/");
                }

                ModelState.AddModelError(nameof(LoginViewModel.Email), "False password or login.");
            }
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    user = new IdentityUser
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = model.Email,
                        UserName = model.UserName,
                        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, model.Password),
                    };

                    if (await roleManager.FindByIdAsync("02d962c8-3531-41e9-bf0f-bdf29fb0b745") == null)
                    {
                        await roleManager.CreateAsync(new IdentityRole
                        {
                            Id = "02d962c8-3531-41e9-bf0f-bdf29fb0b745",
                            Name = "user",
                            NormalizedName = "USER"
                        }); 
                    }

                    var result = await userManager.CreateAsync(user, model.Password);
                    await userManager.AddClaimAsync(user, new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email));
                    await userManager.AddToRoleAsync(user, "user");

                    if (result.Succeeded)
                    {
                        await Authenticate(user);
                        return Redirect(returnUrl ?? "/");
                    }
                }
                else
                {
                    ModelState.AddModelError("", $"USER WITH EMAIL {model.Email} ALREADY EXISTS.");
                }
            }

            ModelState.AddModelError("", "UNCORRECT DATA.");
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Delete(string userId)
        {
            var user = this.userManager.FindByIdAsync(userId).Result;

            if (User.Identity.IsAuthenticated && User.Identity.Name == user.UserName)
            {
                await this.Logout();
            }

            await this.userManager.DeleteAsync(user);

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

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
