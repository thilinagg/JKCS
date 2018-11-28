using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JKCS.Web.Startup))]
namespace JKCS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
