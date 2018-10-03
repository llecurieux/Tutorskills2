using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorskills2.Startup))]
namespace Tutorskills2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
