using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_login.Startup))]
namespace test_login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
