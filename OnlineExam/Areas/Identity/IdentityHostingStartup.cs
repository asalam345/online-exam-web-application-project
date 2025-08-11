using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(OnlineExam.Areas.Identity.IdentityHostingStartup))]
namespace OnlineExam.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}