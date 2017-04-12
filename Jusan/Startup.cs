using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jusan.Startup))]
namespace Jusan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
