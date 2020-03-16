using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAttendanceSystem.Startup))]
namespace MVCAttendanceSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
