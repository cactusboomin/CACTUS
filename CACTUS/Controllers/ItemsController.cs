using CACTUS.Domain;
using CACTUS.Domain.Entities;
using CACTUS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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

        public IActionResult Index(string searchString, SortState sortOrder = SortState.TitleAsc)
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

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(i => (i.Title.Contains(searchString) || searchString.Contains(i.Title))
                                                    || (i.Theme.Contains(searchString) || searchString.Contains(i.Theme)));
            }

            return View(new ItemsViewModel(items.AsNoTracking()));
        }

        public IActionResult Item(Guid id)
        {
            return View(new ItemsViewModel(this.manager, id));
        }

        [Authorize]
        public IActionResult Create(Guid collectionId, string userId)
        {
            return View(new ItemsViewModel
            {
                Item = new Item
                {
                    UserId = userId,
                    CollectionId = collectionId,
                    Collection = this.manager.Collections.GetCollection(collectionId)
                }
            });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(ItemsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var item = model.Item;
                item.Id = Guid.NewGuid();
                item.Collection = model.Collection;
                item.Theme = item.Collection.Theme;
                
                if (model.Collection.Items == null)
                {
                    model.Collection.Items = new List<Item>();
                }

                model.Collection.Items.Add(item);
                this.manager.Items.AddItem(item);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "INVALID DATA");
                return View(model);
            }
        }
    }
}

