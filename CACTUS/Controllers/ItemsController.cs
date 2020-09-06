using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Controllers
{
    public class ItemsController : Controller
    {
        private readonly DataManager manager;

        public ItemsController(DataManager manager)
        {
            this.manager = manager;
        }

        public IActionResult Index(SortState sortOrder = SortState.TitleAsc)
        {
            var items = this.manager.Items.GetItems();

            ViewData["ItemNameSort"] = sortOrder == SortState.TitleAsc ? SortState.TitleDesc : SortState.TitleAsc;
            ViewData["ItemDateSort"] = sortOrder == SortState.DateAsc ? SortState.DateDesc : SortState.DateAsc;

            items = sortOrder switch
            {
                SortState.TitleAsc => items.OrderBy(i => i.Title),
                SortState.TitleDesc => items.OrderByDescending(i => i.Title),
                SortState.DateAsc => items.OrderBy(i => i.TimeAdded),
                SortState.DateDesc => items.OrderByDescending(i => i.TimeAdded),
                _ => items.OrderBy(i => i.Title),
            };

            return View(new ItemsViewModel(items.AsNoTracking()));
        }

        public IActionResult Item(Guid id)
        {
            return View(new ItemsViewModel(this.manager, id));
        }
    }
}
