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

        public IActionResult Index(string searchString, SortState sortOrderItem = SortState.DateDesc, SortState sortOrderCollection = SortState.DateDesc)
        {
            var collections = this.manager.Collections.GetCollections();
            var items = this.manager.Items.GetItems();

            ViewData["CollectionNameSort"] = sortOrderCollection == SortState.TitleAsc ? SortState.DateDesc : SortState.TitleAsc;
            ViewData["CollectionDateSort"] = sortOrderCollection == SortState.DateDesc ? SortState.TitleAsc : SortState.DateDesc;
            ViewData["ItemNameSort"] = sortOrderItem == SortState.TitleAsc ? SortState.DateDesc : SortState.TitleAsc;
            ViewData["ItemDateSort"] = sortOrderItem == SortState.DateDesc ? SortState.TitleAsc : SortState.DateDesc;

            collections = sortOrderCollection switch
            {
                SortState.TitleAsc => collections.OrderBy(c => c.Title),
                SortState.DateDesc => collections.OrderByDescending(c => c.TimeAdded),
                _ => collections.OrderBy(c => c.Title),
            };

            items = sortOrderItem switch
            { 
                SortState.TitleAsc => items.OrderBy(i => i.Title),
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