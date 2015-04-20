using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASWeb2._0.Startup))]
namespace ASWeb2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
