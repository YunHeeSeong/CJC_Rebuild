using System;
using GMINWEB_Rebuild.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GMINWEB_Rebuild.Areas.Identity.IdentityHostingStartup))]
namespace GMINWEB_Rebuild.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GMINWEB_RebuildContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GMINWEB_RebuildContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<GMINWEB_RebuildContext>();

            });
        }
    }
}