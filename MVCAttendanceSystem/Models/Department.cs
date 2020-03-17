using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAttendanceSystem.Models
{
    public class Department
    {
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}