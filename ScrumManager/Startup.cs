using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScrumManager.Startup))]
namespace ScrumManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
