using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kdcx.Startup))]
namespace kdcx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
