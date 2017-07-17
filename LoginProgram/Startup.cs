using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginProgram.Startup))]
namespace LoginProgram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
