using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChipStacker.Startup))]
namespace ChipStacker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
