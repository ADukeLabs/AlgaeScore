using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAlgaeScore.Startup))]
namespace WebAlgaeScore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
