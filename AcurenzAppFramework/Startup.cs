using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcurenzAppFramework.Startup))]
namespace AcurenzAppFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
