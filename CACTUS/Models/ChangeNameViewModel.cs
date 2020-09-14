using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class ChangeNameViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "ENTER NEW USER NAME")]
        [Display(Name = "NEW USER NAME")]
        public string NewName { get; set; }
    }
}
