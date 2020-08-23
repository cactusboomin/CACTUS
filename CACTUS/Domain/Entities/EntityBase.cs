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
        public Guid Id { get; set; }
        
        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Display(Name = "Title image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO metatag title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO metatag description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO metatag keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime TimeAdded { get; set; }
    }
}
