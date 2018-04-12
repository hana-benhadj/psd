using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(psd.Startup))]
namespace psd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
