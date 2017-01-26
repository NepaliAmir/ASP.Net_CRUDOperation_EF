using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_NET_CRUD_Operation.Startup))]
namespace ASP_NET_CRUD_Operation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
