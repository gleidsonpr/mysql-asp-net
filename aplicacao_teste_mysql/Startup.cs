using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aplicacao_teste_mysql.Startup))]
namespace aplicacao_teste_mysql
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
