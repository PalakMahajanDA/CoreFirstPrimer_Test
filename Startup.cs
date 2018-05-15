using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoreFirstPrimer.Startup))]
namespace CoreFirstPrimer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
