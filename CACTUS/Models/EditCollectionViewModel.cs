using CACTUS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class EditCollectionViewModel
    {
        public Collection Collection { get; set; }
        
        [Display(Name = "NEW TITLE")]
        public string Title { get; set; }

        [Display(Name = "NEW DESCRIPTION")]
        public string Description { get; set; }

        [Display(Name = "NEW THEME")]
        public string Theme { get; set; }
    }
}
