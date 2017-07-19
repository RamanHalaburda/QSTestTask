using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QulixTestApp.Models
{
    public class StatusModel
    {
        public int StatusId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}