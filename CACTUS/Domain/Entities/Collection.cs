using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class Collection : EntityBase
    {
        [Required]
        [Display(Name = "DESCRIPTION")]
        public string Description { get; set; }

        #region NUMBERS

        public bool FirstNumberIsEnabled { get; set; } = false;
        public string FirstNumberName { get; set; }

        public bool SecondNumberIsEnabled { get; set; } = false;
        public string SecondNumberName { get; set; }

        public bool ThirdNumberIsEnabled { get; set; } = false;
        public string ThirdNumberName { get; set; }

        #endregion

        #region TEXTS

        public bool FirstTextIsEnabled { get; set; } = false;
        public string FirstTextName { get; set; }

        public bool SecondTextIsEnabled { get; set; } = false;
        public string SecondTextName { get; set; }

        public bool ThirdTextIsEnabled { get; set; } = false;
        public string ThirdTextName { get; set; }

        #endregion

        #region DATES

        public bool FirstDateIsEnabled { get; set; } = false;
        public string FirstDateName { get; set; }

        public bool SecondDateIsEnabled { get; set; } = false;
        public string SecondDateName { get; set; }

        public bool ThirdDateIsEnabled { get; set; } = false;
        public string ThirdDateName { get; set; }

        #endregion

        #region CHECKBOXES

        public bool FirstCheckBoxIsEnabled { get; set; } = false;
        public string FirstCheckBoxName { get; set; }

        public bool SecondCheckBoxIsEnabled { get; set; } = false;
        public string SecondCheckBoxName { get; set; }

        public bool ThirdCheckBoxIsEnabled { get; set; } = false;
        public string ThirdCheckBoxName { get; set; }


        #endregion
    }
}
