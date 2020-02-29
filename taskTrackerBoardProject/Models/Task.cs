using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace taskTrackerBoardProject.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Target Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        //public List<Comment> Comments { get; set; } // all comments on this task with user, datetime, message
        //public Theme CurrentTheme { get; set; } // current color theme for this tasks card, may come from tags, dropdown with all associated tags, or create custom
        //public User CreatedBy { get; set; } // the user that created the task 
        //public Status CurrentStatus { get; set; } // the status is the column that the task is currently in (to do, in progress, finished, etc)
        public string Tag { get; set; } // all the current tags associated with this task, can set color theme, or filter board by tags

    }

    public class TaskDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}