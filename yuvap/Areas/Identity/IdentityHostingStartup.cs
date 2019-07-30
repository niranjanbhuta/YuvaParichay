using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI; // supported in core 2.2 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using yuvap.Areas.Identity.Data;

[assembly: HostingStartup(typeof(yuvap.Areas.Identity.IdentityHostingStartup))]
namespace yuvap.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder){
        
           /* builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(      
                        context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();
            }); */

		
		builder.ConfigureServices((context, services) => {
             /*  services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlite(      
                        context.Configuration.GetConnectionString("DefaultConnection")));                      
               */     
                    //    options.UseSqlite(      
                     //   context.Configuration.GetConnectionString("DefaultConnection")));
                     //nsb 31-12-18
         //            services.AddDbContext<ApplicationDbContext>(options =>
         //   {
         //       options.UseSqlServer(Configuration["AppSettings:ConnectionString"]);
         //   });

            services.AddDbContext<ApplicationDbContext> (options =>                
                //options.UseSqlite
                options.UseSqlServer(                
                    context.Configuration.GetConnectionString("DefaultConnection")) ); // DefaultConnection //YPDatabase



                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();
          });


        }
    } //class
} //name space