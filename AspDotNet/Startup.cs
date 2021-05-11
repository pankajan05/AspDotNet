using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspDotNet.Startup))]
namespace AspDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
