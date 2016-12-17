using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrothersKeepers.Startup))]
namespace BrothersKeepers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
