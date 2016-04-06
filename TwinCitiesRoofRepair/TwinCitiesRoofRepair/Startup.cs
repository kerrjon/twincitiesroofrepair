using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwinCitiesRoofRepair.Startup))]
namespace TwinCitiesRoofRepair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
