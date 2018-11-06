using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BidTownHunterLocal.Startup))]
namespace BidTownHunterLocal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
