using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SD1_sk072215_MIS4200.Startup))]
namespace SD1_sk072215_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
