using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Input the title")]
        [Display(Name = "Title")]
        public new string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
