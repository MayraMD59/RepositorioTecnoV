using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(b.Startup))]
namespace b
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
