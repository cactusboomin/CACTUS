using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => TimeAdded = DateTime.UtcNow;

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "TITLE")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "THEME")]
        public string Theme { get; set; }

        [Display(Name = "TITLE IMAGE")]
        public string TitleImagePath { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TimeAdded { get; set; }
    }
}
