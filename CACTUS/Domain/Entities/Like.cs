using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class Like
    { 
        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        [Required]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
