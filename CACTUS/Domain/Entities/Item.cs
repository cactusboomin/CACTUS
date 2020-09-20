using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeyRed.MarkdownSharp;

namespace CACTUS.Domain.Entities
{
    public class Item : EntityBase
    {
        [Required]
        public Guid CollectionId { get; set; }

        public Collection Collection { get; set; }

        public List<ItemTag> ItemTags { get; set; } = new List<ItemTag>();

        #region NUMBERS

        public double? FirstNumber { get; set; }
        public double? SecondNumber { get; set; }
        public double? ThirdNumber { get; set; }

        #endregion

        #region TEXTS

        public string FirstText { get; set; }
        public string SecondText { get; set; }
        public string ThirdText { get; set; }

        #endregion

        #region DATES

        public DateTime? FirstDate { get; set; }
        public DateTime? SecondDate { get; set; }
        public DateTime? ThirdDate { get; set; }

        #endregion

        #region CHECKBOXES

        public bool? FirstCheckBox { get; set; }
        public bool? SecondCheckBox { get; set; }
        public bool? ThirdCheckBox { get; set; }

        #endregion
    }
}
