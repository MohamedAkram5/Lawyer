using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lawyer_2.Startup))]
namespace Lawyer_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
