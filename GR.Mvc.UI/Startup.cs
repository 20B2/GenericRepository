using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GR.Mvc.UI.Startup))]
namespace GR.Mvc.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
