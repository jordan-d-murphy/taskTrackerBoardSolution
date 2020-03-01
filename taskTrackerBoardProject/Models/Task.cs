using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace taskTrackerBoardProject.Models
{
    public enum Status
    {
        Upcoming,
        Active,
        Completed,
        Paused,
        Archived
    }

    public class Task
    {
        private DateTime _created = DateTime.Now;

        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get { return _created; } }

        [Display(Name = "Target Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        //public List<Comment> Comments { get; set; } // all comments on this task with user, datetime, message
        //public Theme CurrentTheme { get; set; } // current color theme for this tasks card, may come from tags, dropdown with all associated tags, or create custom
        //public User CreatedBy { get; set; } // the user that created the task
        [Display(Name = "Current Status")]
        public Status CurrentStatus { get; set; } // the status is the column that the task is currently in (to do, in progress, finished, etc)
        public string Tag { get; set; } // all the current tags associated with this task, can set color theme, or filter board by tags

    }

    public class TaskDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}