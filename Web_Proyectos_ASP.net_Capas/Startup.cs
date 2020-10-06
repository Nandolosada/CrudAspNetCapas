using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Proyectos_ASP.net_Capas.Startup))]
namespace Web_Proyectos_ASP.net_Capas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
