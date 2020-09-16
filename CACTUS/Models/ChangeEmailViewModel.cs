using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class ChangeEmailViewModel
    {
        public string Id { get; set; }
        
        [Required(ErrorMessage = "ENTER NEW EMAIL")]
        [Display(Name = "NEW EMAIL")]
        public string NewEmail { get; set; }
    }
}
