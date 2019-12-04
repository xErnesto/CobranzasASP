using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CobranzasASP.Startup))]
namespace CobranzasASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
