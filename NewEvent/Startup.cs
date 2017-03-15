using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewEvent.Startup))]
namespace NewEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
