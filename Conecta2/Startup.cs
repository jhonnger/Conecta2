using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conecta2.Startup))]
namespace Conecta2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
