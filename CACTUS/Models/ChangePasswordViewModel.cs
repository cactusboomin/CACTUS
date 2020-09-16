using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "INPUT NEW PASSWORD")]
        [DataType(DataType.Password)]
        [Display(Name = "NEW PASSWORD")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "CONFIRM NEW PASSWORD")]
        [DataType(DataType.Password)]
        [Display(Name = "CONFIRM NEW PASSWORD")]
        public string NewPasswordConfirm { get; set; }
    }
}
