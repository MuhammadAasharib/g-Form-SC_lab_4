using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G_form_lab_3.Startup))]
namespace G_form_lab_3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
