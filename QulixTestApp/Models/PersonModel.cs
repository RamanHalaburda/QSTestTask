using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QulixTestApp.Models
{
    public class PersonModel
    {
        // fields
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "SecondName")]
        public string SecondName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        // constructor
        public PersonModel(int _id, string _f, string _s, string _l)
        {
            this.PersonId = _id;
            this.FirstName = _f;
            this.SecondName = _s;
            this.LastName = _l;
        }

        // constructor
        public PersonModel(int _id)
        {
            this.PersonId = _id;
            this.FirstName = null;
            this.SecondName = null;
            this.LastName = null;
        }
    }
}