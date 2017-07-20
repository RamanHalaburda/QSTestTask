using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QulixTestApp.Models
{
    public class StatusModel
    {
        // fields
        public short StatusId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        // constructor
        public StatusModel(short _id, string _name)
        {
            this.StatusId = _id;
            this.Name = _name;
        }
    }
}