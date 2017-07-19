using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QulixTestApp.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "DаteStart")]
        public string DateS { get; set; }

        [Required]
        [Display(Name = "DateFinish")]
        public string DateF { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; }

        [Required]
        [Display(Name = "Person")]
        public int Form { get; set; }
    }
}