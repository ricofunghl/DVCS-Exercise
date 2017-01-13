using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(newWebsite.Startup))]
namespace newWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
