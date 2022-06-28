using System;
using FarsiTech.Areas.Identity.Data;
using FarsiTech.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FarsiTech.Areas.Identity.IdentityHostingStartup))]
namespace FarsiTech.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FarsiTechContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FarsiTechContextConnection")));

                services.AddDefaultIdentity<FarsiTechUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                    .AddEntityFrameworkStores<FarsiTechContext>();
            });
        }
    }
}