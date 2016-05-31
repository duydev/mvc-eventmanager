using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eventmanager.Startup))]
namespace eventmanager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
