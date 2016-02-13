using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplicacion_web.Startup))]
namespace Aplicacion_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
