using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CACTUS.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager manager;

        public HomeController(DataManager manager)
        {
            this.manager = manager;
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel(this.manager));
        }
    }
}