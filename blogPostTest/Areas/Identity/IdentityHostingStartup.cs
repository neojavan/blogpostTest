using System;
using blogPostTest.Areas.Identity.Data;
using blogPostTest.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(blogPostTest.Areas.Identity.IdentityHostingStartup))]
namespace blogPostTest.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<blogPostTestContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("blogPostTestContextConnection")));

                services.AddDefaultIdentity<blogPostTestUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<blogPostTestContext>();
            });
        }
    }
}