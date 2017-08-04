using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyExample.Startup))]
namespace VidlyExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
