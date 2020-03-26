using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAttendanceSystem.Controllers
{
    [Authorize(Roles = "Security")]
    public class SecurityController : Controller
    {
        ApplicationDbContext Context;
        UserManager<ApplicationUser> userManager;
        public SecurityController()
        {
            Context = new ApplicationDbContext();
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        // GET: Security
        public ActionResult Setting()
        {
            var DepartmentId = Context.departments.ToList();
            ViewBag.DepartmentId = new SelectList(DepartmentId, "DepartmentId", "DepartmentName");
            return View();
        }
        public ActionResult TakeAttendance(int? DepartmentId)
        {
            if (DepartmentId == null)
            {
                DepartmentId =(int)TempData["DepartmentId"];
            }
            var currentDate = DateTime.Now.Date;
            var dept = Context.departments.Find(DepartmentId);
            var students = Context.Users.Include(a => a.attendances)
                .Where(u => !Context.attendances
                .Any(a => a.ApplicationUserId == u.Id && a.Date == currentDate) && u.DepartmentId == dept.DepartmentId)
                .Select(u => u).ToList();
            return View(students);
        }
        public ActionResult Attend(string Id)
        {
            var std = Context.Users.Find(Id);
            int DepartmentId = (int)std.DepartmentId;
            var currentTime = DateTime.Now;
            string studentStatus = "";
            if (currentTime.Hour<=9 && currentTime.Minute <= 15)
            {
                studentStatus = "OnTime";
            }
            else
            {
                studentStatus = "Late";
            }
            Attendance newAttend = new Attendance
            {
                ApplicationUserId = Id,
                Date = DateTime.Now.Date,
                ArrivalTime = DateTime.Now,
                ExitTime = DateTime.Now,
                applicationUser = std,
                Status = studentStatus
            };
            Context.attendances.Add(newAttend);
            Context.SaveChanges();
            TempData["DepartmentId"] = DepartmentId;
            return RedirectToAction("TakeAttendance","security", new { id = DepartmentId });
        }

        public ActionResult departure()
        {
            var DepartmentId = Context.departments.ToList();
            ViewBag.DepartmentId = new SelectList(DepartmentId, "DepartmentId", "DepartmentName");
            return View();
        }
        public ActionResult departureStudents(int? DepartmentId)
        {
            if (DepartmentId == null)
            {
                DepartmentId = (int)TempData["DeptId"];
            }
            var currentDate = DateTime.Now.Date;
            var dept = Context.departments.Find(DepartmentId);
            var students = Context.attendances.Include("ApplicationUser")
                .Where(att => att.applicationUser.DepartmentId == dept.DepartmentId && att.Date == currentDate && att.ArrivalTime == att.ExitTime)
                .ToList();
            return View(students);
        }
        public ActionResult StudnetExit(string Id)
        {
            var std = Context.Users.Find(Id);
            int DepartmentId = (int)std.DepartmentId;
            var currentTime = DateTime.Now;
            var setExitTime = Context.attendances.Where(att => att.ApplicationUserId == std.Id && att.Date == currentTime.Date).FirstOrDefault();
            setExitTime.ExitTime = currentTime;
            Context.SaveChanges();
            TempData["DeptId"] = DepartmentId;
            return RedirectToAction("departureStudents", "security", new { id = DepartmentId });
        }
    }
}