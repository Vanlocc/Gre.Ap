using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gre.Ap.Startup))]
namespace Gre.Ap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
