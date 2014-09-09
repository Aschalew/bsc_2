using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSC_2007.Startup))]
namespace BSC_2007
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
