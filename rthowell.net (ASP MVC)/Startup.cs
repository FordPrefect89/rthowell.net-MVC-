using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rthowell.net__ASP_MVC_.Startup))]
namespace rthowell.net__ASP_MVC_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
