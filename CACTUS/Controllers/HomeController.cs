using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CACTUS.Domain;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CACTUS.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager manager;

        public HomeController(DataManager manager)
        {
            this.manager = manager;
        }

        public IActionResult Index(string searchString, SortState sortOrder = SortState.TitleAsc)
        {
            var collections = this.manager.Collections.GetCollections();
            var items = this.manager.Items.GetItems();

            ViewData["CollectionNameSort"] = sortOrder == SortState.TitleAsc ? SortState.TitleDesc : SortState.TitleAsc;
            ViewData["CollectionDateSort"] = sortOrder == SortState.DateAsc ? SortState.DateDesc : SortState.DateAsc;
            ViewData["ItemNameSort"] = sortOrder == SortState.TitleAsc ? SortState.TitleDesc : SortState.TitleAsc;
            ViewData["ItemDateSort"] = sortOrder == SortState.DateAsc ? SortState.DateDesc : SortState.DateAsc;

            collections = sortOrder switch
            {
                SortState.TitleAsc => collections.OrderBy(c => c.Title),
                SortState.TitleDesc => collections.OrderByDescending(c => c.Title),
                SortState.DateAsc => collections.OrderBy(c => c.TimeAdded),
                SortState.DateDesc => collections.OrderByDescending(c => c.TimeAdded),
                _ => collections.OrderBy(c => c.Title),
            };

            items = sortOrder switch
            { 
                SortState.TitleAsc => items.OrderBy(i => i.Title),
                SortState.TitleDesc => items.OrderByDescending(i => i.Title),
                SortState.DateAsc => items.OrderBy(i => i.TimeAdded),
                SortState.DateDesc => items.OrderByDescending(i => i.TimeAdded),
                _ => items.OrderBy(i => i.Title),
            };

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(i => (i.Title.Contains(searchString) || searchString.Contains(i.Title))
                                        || i.Theme.Contains(searchString) || searchString.Contains(i.Theme));

                collections = collections.Where(c => (c.Title.Contains(searchString) || searchString.Contains(c.Title))
                                                    || (c.Description.Contains(searchString) || searchString.Contains(c.Description))
                                                    || (c.Theme.Contains(searchString) || searchString.Contains(c.Theme)));
            }

            return View(new HomeViewModel(collections.AsNoTracking().ToList(),
                                            items.AsNoTracking().ToList(),
                                            this.manager.Tags.GetTags().AsNoTracking().ToList()));
        }
    }
}