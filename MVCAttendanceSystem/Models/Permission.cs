using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAttendanceSystem.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string ApplicationUserId { get; set; }
        [Required]
        public string Note { get; set; }
        public string Status { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Permission Date")]
        public DateTime PermissionDate { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public bool IsChecked { get; set; }
    }
}