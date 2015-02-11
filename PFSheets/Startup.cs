using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFSheets.Startup))]
namespace PFSheets
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
