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
        public string FirstNumberName { get; set; }

        public bool SecondNumberIsEnabled { get; set; }
        public string SecondNumberName { get; set; }

        public bool ThirdNumberIsEnabled { get; set; }
        public string ThirdNumberName { get; set; }


        #endregion

        #region TEXTS

        public bool FirstTextIsEnabled { get; set; }
        public string FirstTextName { get; set; }

        public bool SecondTextIsEnabled { get; set; }
        public string SecondTextName { get; set; }

        public bool ThirdTextIsEnabled { get; set; }
        public string ThirdTextName { get; set; }

        #endregion

        #region DATES

        public bool FirstDateIsEnabled { get; set; }
        public string FirstDateName { get; set; }

        public bool SecondDateIsEnabled { get; set; }
        public string SecondDateName { get; set; }

        public bool ThirdDateIsEnabled { get; set; }
        public string ThirdDateName { get; set; }

        #endregion

        #region CHECKBOXES

        public bool FirstCheckBoxIsEnabled { get; set; }
        public string FirstCheckBoxName { get; set; }

        public bool SecondCheckBoxIsEnabled { get; set; }
        public string SecondCheckBoxName { get; set; }

        public bool ThirdCheckBoxIsEnabled { get; set; }
        public string ThirdCheckBoxName { get; set; }

        #endregion
    }
}
