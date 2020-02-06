using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMAC.Startup))]
namespace GMAC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
