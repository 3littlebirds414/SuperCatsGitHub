using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperCats.Startup))]
namespace SuperCats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
