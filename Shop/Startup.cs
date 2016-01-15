using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autentification.Startup))]
namespace Autentification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
