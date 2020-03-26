using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAttendanceSystem.ViewModel
{
    public class AdminPreviewAttendance
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        [Display(Name = "Department")]
        public int Department_Id { get; set; }
        [Required]
        [Display(Name = "From")]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }
        [Required]
        [Display(Name = "To")]
        [DataType(DataType.Date)]
        public DateTime To { get; set; }
    }
}