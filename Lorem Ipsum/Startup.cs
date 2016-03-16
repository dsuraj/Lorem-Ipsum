using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lorem_Ipsum.Startup))]
namespace Lorem_Ipsum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
