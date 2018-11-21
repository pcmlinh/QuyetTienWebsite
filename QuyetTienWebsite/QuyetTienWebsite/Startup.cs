using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuyetTienWebsite.Startup))]
namespace QuyetTienWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
