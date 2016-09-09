using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoesStoreMvc.Startup))]
namespace ShoesStoreMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
