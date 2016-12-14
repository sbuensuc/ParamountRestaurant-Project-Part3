using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParamountRestaurant_Project_Part3.Startup))]
namespace ParamountRestaurant_Project_Part3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
