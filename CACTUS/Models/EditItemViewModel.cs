using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class EditItemViewModel
    {
        public Guid ItemId { get; set; }

        [Display(Name = "NEW TITLE")]
        public string Title { get; set; }

        [Display(Name = "NEW IMAGE")]
        public string TitleImagePath { get; set; }
    }
}
