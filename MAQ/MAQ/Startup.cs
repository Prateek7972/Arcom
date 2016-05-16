using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MAQ.Startup))]
namespace MAQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
