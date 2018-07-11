using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookShelfProject.Startup))]
namespace BookShelfProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
