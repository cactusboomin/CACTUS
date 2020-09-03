using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class Tag
    {
        public Tag()
        {
            this.ItemTags = new List<ItemTag>();
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "NAME")]
        public string Name { get; set; }

        public List<ItemTag> ItemTags { get; set; }
    }
}
