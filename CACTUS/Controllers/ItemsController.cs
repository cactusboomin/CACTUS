using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Controllers
{
    public class ItemsController : Controller
    {
        private DataManager manager;

        public ItemsController(DataManager manager)
        {
            this.manager = manager;
        }

        public IActionResult Index()
        {
            return View(new ItemsViewModel(this.manager));
        }
    }
}
