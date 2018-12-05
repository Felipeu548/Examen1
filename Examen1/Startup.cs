using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen1.Startup))]
namespace Examen1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
