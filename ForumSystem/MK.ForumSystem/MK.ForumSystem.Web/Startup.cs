using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MK.ForumSystem.Web.Startup))]
namespace MK.ForumSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
