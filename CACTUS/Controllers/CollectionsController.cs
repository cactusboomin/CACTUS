using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly DataManager manager;

        public CollectionsController(DataManager manager, AppDbContext context)
        {
            this.manager = manager;
        }

        public IActionResult Index(SortState sortOrder = SortState.TitleAsc)
        {
            var collections = this.manager.Collections.GetCollections();

            ViewData["CollectionNameSort"] = sortOrder == SortState.TitleAsc ? SortState.TitleDesc : SortState.TitleAsc;
            ViewData["CollectionDateSort"] = sortOrder == SortState.DateAsc ? SortState.DateDesc : SortState.DateAsc;
            
            collections = sortOrder switch
            {
                SortState.TitleAsc => collections.OrderBy(c => c.Title),
                SortState.TitleDesc => collections.OrderByDescending(c => c.Title),
                SortState.DateAsc => collections.OrderBy(c => c.TimeAdded),
                SortState.DateDesc => collections.OrderByDescending(c => c.TimeAdded),
                _ => collections.OrderBy(c => c.Title),
            };

            return View(new CollectionsViewModel(collections.AsNoTracking()));
        }

        public IActionResult Collection(Guid id)
        {
            return View(new CollectionsViewModel(this.manager, id));
        }
    }
}
