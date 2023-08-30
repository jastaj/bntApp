using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bntApp.Startup))]
namespace bntApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
