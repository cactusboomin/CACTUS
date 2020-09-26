using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "ENTER EMAIL")]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ENTER PASSWORD")]
        [DataType(DataType.Password)]
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }

        [Required(ErrorMessage = "CONFIRM PASSWORD")]
        [Compare("Password", ErrorMessage = "PASSWORDS AREN'T SAME")]
        [DataType(DataType.Password)]
        [Display(Name = "CONFIRM PASSWORD")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "ENTER USER NAME")]
        [Display(Name = "USER NAME")]
        public string UserName { get; set; }
    }
}
