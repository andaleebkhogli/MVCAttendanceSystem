using MVCAttendanceSystem.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAttendanceSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        ApplicationDbContext Context;
        public StudentController()
        {
            Context = new ApplicationDbContext();
        }
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Id = User.Identity.GetUserId();
            return View();
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
                return Content("Done");
            }

            return View("TakePermission");
        }
    }
}