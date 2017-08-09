using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BenhVien.Startup))]

namespace BenhVien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}