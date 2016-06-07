using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B_K_MVC.Startup))]
namespace B_K_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
