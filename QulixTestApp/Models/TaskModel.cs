using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QulixTestApp.Models
{
    public class TaskModel
    {
        // fields
        public int TaskId { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "DаteStart")]
        public DateTime DateS { get; set; }

        [Required]
        [Display(Name = "DateFinish")]
        public DateTime DateF { get; set; }

        [Required]
        [Display(Name = "Status")]
        public StatusModel Status { get; set; }

        [Required]
        [Display(Name = "Person")]
        public PersonModel Person { get; set; }

        // constructor
        public TaskModel(int _id)
        {
            this.TaskId = _id;
            this.Name = null;
            this.Amount = 0;
            this.DateS = new DateTime(0);
            this.DateF = new DateTime(0);
            this.Status = null;
            this.Person = null;
        }

        // constructor
        public TaskModel(int _id, string _name, int _am, DateTime _ds, DateTime _df, StatusModel _s, PersonModel _p)
        {
            this.TaskId = _id;
            this.Name = _name;
            this.Amount = _am;
            this.DateS = _ds;
            this.DateF = _df;
            this.Status = _s;
            this.Person = _p;
        }
    }
}