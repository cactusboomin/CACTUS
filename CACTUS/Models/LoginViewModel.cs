using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "ENTER EMAIL")]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ENTER PASSWORD")]
        [UIHint("password")]
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }

        [Display(Name = "REMEMBER ME?")]
        public bool RememberMe { get; set; }
    }
}
