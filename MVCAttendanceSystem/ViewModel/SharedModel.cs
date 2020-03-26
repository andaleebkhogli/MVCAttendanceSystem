using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCAttendanceSystem.Models;

namespace MVCAttendanceSystem.ViewModel
{
    public class SharedModel
    {
        public string userName { get; set; }
        public int OnTime { get; set; }
        public int Late { get; set; }
        public int Permission { get; set; }
        public int Apscent { get; set; }
    }
}