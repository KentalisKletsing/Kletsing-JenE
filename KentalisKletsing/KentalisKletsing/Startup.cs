using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KentalisKletsing.Startup))]
namespace KentalisKletsing
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
