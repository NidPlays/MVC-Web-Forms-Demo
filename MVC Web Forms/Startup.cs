using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Web_Forms.Startup))]
namespace MVC_Web_Forms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
