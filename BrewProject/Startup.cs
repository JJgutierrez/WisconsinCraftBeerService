using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrewProject.Startup))]
namespace BrewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
