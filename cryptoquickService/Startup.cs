using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(cryptoquickService.Startup))]

namespace cryptoquickService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}