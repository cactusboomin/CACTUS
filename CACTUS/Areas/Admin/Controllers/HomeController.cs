using CACTUS.Domain;
using CACTUS.Domain.Entities;
using CACTUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Delete(Guid id)
        {
            var items = this.manager.Items.GetItems();
            var tags = this.manager.Tags.GetTags();
            var collection = this.manager.Collections.GetCollections();

            var deletedItems = items.Include(i => i.Collection)
                                    .Include(i => i.ItemTags)
                                    .ThenInclude(it => it.Tag)
                                    .Where(i => i.Collection.Id == id)
                                    .ToList();
            
            var deletedTags = new List<Tag>();

            foreach (var t in tags.ToList())
            {
                foreach (var i in deletedItems)
                {
                    foreach (var it in i.ItemTags)
                    {
                        if (it.TagId == t.Id && t.ItemTags.Count == 1)
                        {
                            deletedTags.Add(t);
                        }
                    }
                }
            }

            var deletedCollection = this.manager.Collections.GetCollection(id);
            
            foreach (var i in deletedItems)
            {
                items.ToList().Remove(i);
            }

            foreach (var t in deletedTags)
            {
                tags.ToList().Remove(t);
            }

            collection.ToList().Remove(deletedCollection);

            return RedirectToAction("Index", "Home");
        }
    }
}
