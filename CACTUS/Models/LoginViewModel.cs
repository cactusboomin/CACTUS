using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "LOGIN")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "PASSWORD")]
        public string Password { get; set; }

        [Display(Name = "REMEMBER ME?")]
        public bool RememberMe { get; set; }
    }
}
