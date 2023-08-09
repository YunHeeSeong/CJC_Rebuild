using System;
using GMINWEB_CJC.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GMINWEB_CJC.Areas.Identity.IdentityHostingStartup))]
namespace GMINWEB_CJC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GMINWEB_CJCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GMINWEB_CJCContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<GMINWEB_CJCContext>();

            });
        }
    }
}