using CACTUS.Domain;
using CACTUS.Domain.Entities;
using CACTUS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
                                                    || (c.Description.Contains(searchString) || searchString.Contains(c.Description))
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
        [HttpGet]
        public IActionResult Create(string userId)
        {
            ViewBag.Theme = new SelectList(Themes.List);

            return View(new CollectionsViewModel
            {
                Collection = new Collection { UserId = userId }
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create([FromForm]CollectionsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var collection = model.Collection;

                #region NUMBERS
                if (collection.FirstNumberName != null)
                {
                    collection.FirstNumberIsEnabled = true;
                }
                else
                {
                    collection.FirstNumberIsEnabled = false;
                }
                if (collection.SecondNumberName != null)
                {
                    collection.SecondNumberIsEnabled = true;
                }
                else
                {
                    collection.SecondNumberIsEnabled = false;
                }
                if (collection.ThirdNumberName != null)
                {
                    collection.ThirdNumberIsEnabled = true;
                }
                else
                {
                    collection.ThirdNumberIsEnabled = false;
                }
                #endregion
                #region TEXTS
                if (collection.FirstTextName != null)
                {
                    collection.FirstTextIsEnabled = true;
                }
                else
                {
                    collection.FirstTextIsEnabled = false;
                }
                if (collection.SecondTextName != null)
                {
                    collection.SecondTextIsEnabled = true;
                }
                else
                {
                    collection.SecondTextIsEnabled = false;
                }
                if (collection.ThirdTextName != null)
                {
                    collection.ThirdTextIsEnabled = true;
                }
                else
                {
                    collection.SecondTextIsEnabled = false;
                }
                #endregion
                #region DATES
                if (collection.FirstDateName != null)
                {
                    collection.FirstDateIsEnabled = true;
                }
                else
                {
                    collection.FirstDateIsEnabled = false;
                }
                if (collection.SecondDateName != null)
                {
                    collection.SecondDateIsEnabled = true;
                }
                else
                {
                    collection.SecondDateIsEnabled = false;
                }
                if (collection.ThirdDateName != null)
                {
                    collection.ThirdDateIsEnabled = true;
                }
                else
                {
                    collection.ThirdDateIsEnabled = false;
                }
                #endregion
                #region CHECKBOXES
                if (collection.FirstCheckBoxName != null)
                {
                    collection.FirstCheckBoxIsEnabled = true;
                }
                else
                {
                    collection.FirstCheckBoxIsEnabled = false;
                }
                if (collection.SecondCheckBoxName != null)
                {
                    collection.SecondCheckBoxIsEnabled = true;
                }
                else
                {
                    collection.SecondCheckBoxIsEnabled = false;
                }
                if (collection.ThirdCheckBoxName != null)
                {
                    collection.ThirdCheckBoxIsEnabled = true;
                }
                else
                {
                    collection.ThirdCheckBoxIsEnabled = false;
                }
                #endregion

                this.manager.Collections.AddCollection(collection);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Theme = new SelectList(Themes.List);

                ModelState.AddModelError(string.Empty, "INVALID DATA");
                return View(model);
            }
        }

        [Authorize]
        public IActionResult Edit(Guid collectionId)
        {
            return View(new CollectionsViewModel
            {
                Collection = this.manager.Collections.GetCollection(collectionId)
            });
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditTitle(Guid collectionId)
        {
            var collection = this.manager.Collections.GetCollection(collectionId);
            return View(new EditCollectionViewModel
            {
                Collection = collection,
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditTitle([FromForm]EditCollectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var collection = this.manager.Collections.GetCollection(model.Collection.Id);
                collection.Title = model.Title;

                this.manager.Collections.SaveCollection(collection);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                model.Collection = this.manager.Collections.GetCollection(model.Collection.Id);
                return View(model);
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditDescription(Guid collectionId)
        {
            var collection = this.manager.Collections.GetCollection(collectionId);
            return View(new EditCollectionViewModel
            {
                Collection = collection,
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditDescription([FromForm]EditCollectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var collection = this.manager.Collections.GetCollection(model.Collection.Id);
                collection.Description = model.Description;

                this.manager.Collections.SaveCollection(collection);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                model.Collection = this.manager.Collections.GetCollection(model.Collection.Id);
                return View(model);
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditTheme(Guid collectionId)
        {
            ViewBag.Theme = new SelectList(Themes.List);

            return View(new EditCollectionViewModel
            {
                Collection = this.manager.Collections.GetCollection(collectionId)
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditTheme(EditCollectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var collection = this.manager.Collections.GetCollection(model.Collection.Id);
                collection.Theme = model.Theme;

                this.manager.Collections.SaveCollection(collection);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Theme = new SelectList(Themes.List);
                return View(model);
            }
        }

        [Authorize]
        public IActionResult Delete(Guid collectionId)
        {
            this.manager.Collections.DeleteCollection(collectionId);

            return RedirectToAction("Index", "Home");
        }
    }
}
