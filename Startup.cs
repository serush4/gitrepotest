using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sureshapp.Startup))]
namespace sureshapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
