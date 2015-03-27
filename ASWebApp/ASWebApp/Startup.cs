using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASWebApp.Startup))]
namespace ASWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
