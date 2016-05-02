using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContentStoreAdmin.Startup))]
namespace ContentStoreAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
