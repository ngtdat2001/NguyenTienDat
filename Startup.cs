using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTienDat.Startup))]
namespace NguyenTienDat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
