using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskManagement.Models
{
    public class ProjectTaskModel
    {
        [Required(ErrorMessage ="Task Title is Mandatory.")]
        public string Label { get; set; }
        [Required(ErrorMessage = "Project is Mandatory.")]
        public int ProjectId { get; set; }

        public IEnumerable<SelectListItem> Projects { get; set; }
        
        public IEnumerable<SelectListItem> Priorities { get; set; }
        [Required(ErrorMessage = "Priority is Mandatory.")]
        public int PriorityStatusId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TaskStatusId { get; set; }

    }
}