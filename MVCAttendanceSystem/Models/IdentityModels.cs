using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCAttendanceSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name ="Department")]
        public int? DepartmentId { get; set; }
        public List<Permission> permissions { get; set; }
        public List<Attendance> attendances { get; set; }
        public Department department { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<Permission> permissions { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public System.Data.Entity.DbSet<MVCAttendanceSystem.Models.ApplicationUser> ApplicationUsers { get; set; }

        //public System.Data.Entity.DbSet<MVCAttendanceSystem.Models.ApplicationUser> ApplicationUsers { get; set; }

        //public System.Data.Entity.DbSet<MVCAttendanceSystem.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}