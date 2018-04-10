using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirmaKurierska.Startup))]
namespace FirmaKurierska
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
