using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class Tag
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "NAME")]
        public string Name { get; set; }

        public List<ItemTag> ItemTags { get; set; } = new List<ItemTag>();
    }
}
