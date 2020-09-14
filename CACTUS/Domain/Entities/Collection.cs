using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class Collection : EntityBase
    {
        public Collection()
        {
            this.Items = new List<Item>();
        }

        [Required]
        [Display(Name = "DESCRIPTION")]
        public string Description { get; set; }

        public List<Item> Items { get; set; }

        #region NUMBERS

        public bool FirstNumberIsEnabled { get; set; }
        [Display(Name = "FIRST NUMBER NAME:")]
        public string FirstNumberName { get; set; }

        public bool SecondNumberIsEnabled { get; set; }
        [Display(Name = "SECOND NUMBER NAME:")]
        public string SecondNumberName { get; set; }

        public bool ThirdNumberIsEnabled { get; set; }
        [Display(Name = "THIRD NUMBER NAME:")]
        public string ThirdNumberName { get; set; }


        #endregion

        #region TEXTS

        public bool FirstTextIsEnabled { get; set; }
        [Display(Name = "FIRST TEXT NAME:")]
        public string FirstTextName { get; set; }

        public bool SecondTextIsEnabled { get; set; }
        [Display(Name = "SECOND TEXT NAME:")]
        public string SecondTextName { get; set; }

        public bool ThirdTextIsEnabled { get; set; }
        [Display(Name = "THIRD TEXT NAME:")]
        public string ThirdTextName { get; set; }

        #endregion

        #region DATES

        public bool FirstDateIsEnabled { get; set; }
        [Display(Name = "FIRST DATE NAME:")]
        public string FirstDateName { get; set; }

        public bool SecondDateIsEnabled { get; set; }
        [Display(Name = "SECOND DATE NAME:")]
        public string SecondDateName { get; set; }

        public bool ThirdDateIsEnabled { get; set; }
        [Display(Name = "THIRD DATE NAME:")]
        public string ThirdDateName { get; set; }

        #endregion

        #region CHECKBOXES

        public bool FirstCheckBoxIsEnabled { get; set; }
        [Display(Name = "FIRST VALUE NAME:")]
        public string FirstCheckBoxName { get; set; }

        public bool SecondCheckBoxIsEnabled { get; set; }
        [Display(Name = "SECOND VALUE NAME:")]
        public string SecondCheckBoxName { get; set; }

        public bool ThirdCheckBoxIsEnabled { get; set; }
        [Display(Name = "THIRD VALUE NAME:")]
        public string ThirdCheckBoxName { get; set; }

        #endregion
    }
}
