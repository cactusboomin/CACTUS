﻿using CACTUS.Domain;
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

        public IActionResult Index(string email)
        {
            var user = userManager.FindByEmailAsync(email);
            return View();
        }
    }
}
