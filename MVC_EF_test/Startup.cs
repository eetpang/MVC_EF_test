using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_EF_test.Startup))]
namespace MVC_EF_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
