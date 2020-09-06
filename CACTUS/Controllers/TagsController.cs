using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Controllers
{
    public class TagsController : Controller
    {
        private readonly DataManager manager;

        public TagsController(DataManager manager)
        {
            this.manager = manager;
        }

        public IActionResult Index()
        {
            return View(new TagsViewModel(this.manager));
        }

        public IActionResult Tag(Guid id)
        {
            return View(new TagsViewModel(this.manager, id));
        }
    }
}
