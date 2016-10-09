using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wow.Identiry.Startup))]
namespace Wow.Identiry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
