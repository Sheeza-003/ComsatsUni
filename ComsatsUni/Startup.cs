using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComsatsUni.Startup))]
namespace ComsatsUni
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
