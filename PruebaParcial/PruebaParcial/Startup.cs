using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaParcial.Startup))]
namespace PruebaParcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
