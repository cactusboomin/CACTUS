using CACTUS.Domain;
using CACTUS.Domain.Entities;
using CACTUS.Models;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Index(string searchString, SortState sortOrder = SortState.TitleAsc)
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

            if (!string.IsNullOrEmpty(searchString))
            {
                collections = collections.Where(c => (c.Title.Contains(searchString) || searchString.Contains(c.Title))
                                                    || (c.Description.Contains(searchString)||searchString.Contains(c.Description))
                                                    || (c.Theme.Contains(searchString) || searchString.Contains(c.Theme)));
            }

            return View(new CollectionsViewModel(collections.AsNoTracking()));
        }

        public IActionResult Collection(string searchString, Guid id)
        {
            var items = this.manager.Collections.GetCollection(id).Items.AsQueryable()
                                                                        .Include(i => i.Collection)
                                                                        .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(i => (i.Title.Contains(searchString) || searchString.Contains(i.Title))
                             || (i.Theme.Contains(searchString) || searchString.Contains(i.Theme)));
            }

            return View(new CollectionsViewModel(this.manager, items, id));
        }

        [Authorize]
        public IActionResult Create(string userId, string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new CollectionsViewModel { UserId = userId });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(CollectionsViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var collection = model.Collection;

                #region NUMBERS
                if (collection.FirstNumberName != null)
                {
                    collection.FirstNumberIsEnabled = true;
                }
                if (collection.SecondNumberName != null)
                {
                    collection.SecondNumberIsEnabled = true;
                }
                if (collection.ThirdNumberName != null)
                {
                    collection.ThirdNumberIsEnabled = true;
                }
                #endregion
                #region TEXTS
                if (collection.FirstTextName != null)
                {
                    collection.FirstTextIsEnabled = true;
                }
                if (collection.SecondTextName != null)
                {
                    collection.SecondTextIsEnabled = true;
                }
                if (collection.ThirdTextName != null)
                {
                    collection.ThirdTextIsEnabled = true;
                }
                #endregion
                #region DATES
                if (collection.FirstDateName != null)
                {
                    collection.FirstDateIsEnabled = true;
                }
                if (collection.SecondDateName != null)
                {
                    collection.SecondDateIsEnabled = true;
                }
                if (collection.ThirdDateName != null)
                {
                    collection.ThirdDateIsEnabled = true;
                }
                #endregion
                #region CHECKBOXES
                if (collection.FirstCheckBoxName != null)
                {
                    collection.FirstCheckBoxIsEnabled = true;
                }
                if (collection.SecondCheckBoxName != null)
                {
                    collection.SecondCheckBoxIsEnabled = true;
                }
                if (collection.ThirdCheckBoxName != null)
                {
                    collection.ThirdCheckBoxIsEnabled = true;
                }
                #endregion

                collection.UserId = model.UserId;
                collection.Id = Guid.NewGuid();

                this.manager.Collections.AddCollection(collection);

                return Redirect(returnUrl ?? "/");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "INVALID DATA");
                return View(model);
            }
        }
    }
}
