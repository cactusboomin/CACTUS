using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Areas.Admin.Controllers
{
    [Area("Admin")]
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
