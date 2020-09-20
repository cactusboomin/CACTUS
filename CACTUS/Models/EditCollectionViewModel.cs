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
        
        [Display(Name = "TITLE")]
        public string NewTitle { get; set; }

        [Display(Name = "DESCRIPTION")]
        public string Description { get; set; }

        [Display(Name = "THEME")]
        public string Theme { get; set; }
    }
}
