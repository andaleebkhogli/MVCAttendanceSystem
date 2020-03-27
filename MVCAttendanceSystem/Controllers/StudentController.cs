using MVCAttendanceSystem.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCAttendanceSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        UserManager<ApplicationUser> userManager;
        ApplicationDbContext Context;
        
        public StudentController()
        {
            Context = new ApplicationDbContext();
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        // GET: Student
        public ActionResult Index()
        {
            var stid = User.Identity.GetUserId();
            ViewBag.Name = User.Identity.Name;
            var student = userManager.FindById(stid);
            var studentbyID = userManager.Users.Include(a => a.department).FirstOrDefault(s => s.Id == student.Id);
            var permission = Context.permissions.FirstOrDefault(p => p.ApplicationUserId == stid);
            if(permission != null)
            {
                ViewBag.Status = permission.Status;
            }
            return View(studentbyID);
        }
        

        public ActionResult TakePermission()
        {
            ViewBag.ApplicationUserId = User.Identity.GetUserId();
            var permissions = new Permission();
            return View(permissions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakePermission(Permission pr)
        {
            if (ModelState.IsValid)
            {
                if (pr.Status == null)
                    pr.Status = "Waiting";
                Context.permissions.Add(pr);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("TakePermission");
        }
        
        
        public ActionResult ViewMyAttendance()
        {
            var currentUser = User.Identity.GetUserId();
            var attendance = Context.attendances.Where(q => q.ApplicationUserId == currentUser).ToList();
            return View(attendance);
        }
    }
}
