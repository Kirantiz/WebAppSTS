using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSTS.Startup))]
namespace WebAppSTS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
