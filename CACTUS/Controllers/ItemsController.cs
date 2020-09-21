using CACTUS.Domain;
using CACTUS.Domain.Entities;
using CACTUS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> userManager;

        public ItemsController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
        }

        public IActionResult Index(string searchString, SortState sortOrder = SortState.TitleAsc)
        {
            var items = this.dataManager.Items.GetItems();

            ViewData["ItemNameSort"] = sortOrder == SortState.TitleAsc ? SortState.DateDesc : SortState.TitleAsc;
            ViewData["ItemDateSort"] = sortOrder == SortState.DateDesc ? SortState.TitleAsc : SortState.DateDesc;

            items = sortOrder switch
            {
                SortState.TitleAsc => items.OrderBy(i => i.Title),
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
            return View(new ItemsViewModel(this.dataManager, id));
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create(Guid collectionId)
        {
            var collection = this.dataManager.Collections.GetCollection(collectionId);

            return View(new ItemsViewModel
            {
                Item = new Item
                {
                    UserId = collection.UserId,
                    Collection = collection,
                    CollectionId = collection.Id,
                    Theme = collection.Theme
                },
                Collection = collection
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create([FromForm]ItemsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var item = model.Item;
                item.Collection = this.dataManager.Collections.GetCollection(item.CollectionId);
                
                this.dataManager.Items.AddItem(item);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        [Authorize]
        public IActionResult Edit(Guid itemId)
        {
            var item = this.dataManager.Items.GetItem(itemId);
            var user = this.userManager.FindByIdAsync(item.UserId).Result;
            string userName = null;

            if (user != null)
            {
                userName = user.UserName;    
            }

            return View(new ItemsViewModel
            {
                Item = item,
                UserName = userName
            });
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditTitle(Guid itemId)
        {
            return View(new EditItemViewModel
            {
                ItemId = itemId
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditTitle([FromForm]EditItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var item = this.dataManager.Items.GetItem(model.ItemId);
                item.Title = model.Title;

                this.dataManager.Items.SaveItem(item);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddTag(Guid itemId)
        {
            return View(new AddTagViewModel { ItemId = itemId });
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddTag(AddTagViewModel model)
        {
            if (ModelState.IsValid)
            {
                var checkTag = this.dataManager.Tags.GetTag(model.Tag);

                if (checkTag == null)
                {
                    var tag = new Tag
                    {
                        Id = Guid.NewGuid(),
                        Name = model.Tag
                    };

                    this.dataManager.Tags.AddTag(tag);

                    var item = this.dataManager.Items.GetItem(model.ItemId);

                    item.ItemTags.Add(new ItemTag
                    {
                        Item = item,
                        ItemId = item.Id,
                        Tag = tag,
                        TagId = tag.Id
                    });

                    this.dataManager.Items.SaveItem(item);
                    this.dataManager.Tags.SaveTag(tag);
                }
                else
                {
                    var item = this.dataManager.Items.GetItem(model.ItemId);

                    item.ItemTags.Add(new ItemTag
                    {
                        Item = item,
                        ItemId = item.Id,
                        Tag = checkTag,
                        TagId = checkTag.Id
                    });

                    this.dataManager.Items.SaveItem(item);
                    this.dataManager.Tags.SaveTag(checkTag);
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        [Authorize]
        public IActionResult Delete(Guid itemId)
        {
            this.dataManager.Items.DeleteItem(itemId);

            return RedirectToAction("Index", "Home");
        }
    }
}

