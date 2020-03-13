﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        public virtual ApplicationUser User { get; set; }


    }
}