﻿using CACTUS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class AddTagViewModel
    {
        public DataManager manager { get; set; }

        [Required]
        public Guid ItemId { get; set; }

        [Required(ErrorMessage = "INPUT NAME OF THE TAG")]
        [Display(Name = "TAG")]
        public string Tag { get; set; }
    }
}
