using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medicus_V1._6._2.Startup))]
namespace Medicus_V1._6._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
