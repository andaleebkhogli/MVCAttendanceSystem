using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAttendanceSystem.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public string ApplicationUserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Arrival Time")]
        public DateTime ArrivalTime { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Exit Time ")]
        public DateTime ExitTime { get; set; }
        public string Status { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}