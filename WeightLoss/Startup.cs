using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeightLoss.Startup))]
namespace WeightLoss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
