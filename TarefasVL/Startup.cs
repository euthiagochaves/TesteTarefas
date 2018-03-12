using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TarefasVL.Startup))]
namespace TarefasVL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
