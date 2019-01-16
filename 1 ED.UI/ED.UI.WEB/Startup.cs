using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ED.UI.WEB.Startup))]
namespace ED.UI.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
