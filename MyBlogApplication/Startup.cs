using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBlogApplication.Startup))]
namespace MyBlogApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
