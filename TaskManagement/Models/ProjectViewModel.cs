using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagement.Models
{
    public class ProjectViewModel
    {
        [Required]
        [MinLength(2)]
        public string Label { get; set; }
    }
}