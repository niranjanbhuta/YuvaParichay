using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yuvap.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using yuvap.Models; 

namespace yuvap
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

           // services.AddDbContext<ApplicationDbContext>(options =>
           //     options.UseSqlite(
           //         Configuration.GetConnectionString("DefaultConnection")));
            
             services.AddDbContext<YPContext> (options =>                
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")) );
               // options.UseInMemoryDatabase("YPConnection");
            
           // services.AddDefaultIdentity<IdentityUser>()
               // .AddDefaultUI(UIFramework.Bootstrap4) 
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
           // services.AddIdentityCore<IdentityUser>()
           //     .AddDefaultUI(UIFramework.Bootstrap4) 
           //    .AddEntityFrameworkStores<ApplicationDbContext>();



           // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        
                services.AddMvc()
    .AddRazorPagesOptions(options =>
    {
        options.Conventions.AuthorizePage("/YP/pProcess/Admin");
       // options.Conventions.AuthorizeFolder("/Private");
       // options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
       // options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
    })
    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
                
     }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}


/*
Note:
(5) Delete all records from table: https://stackoverflow.com/questions/15220411/entity-framework-delete-all-rows-in-table
(4)Problem Solved by Mofying:- IdentityHostingStartup.cs
(3) yuvap.csproj
<PackageReference Include="Microsoft.AspNetCore.Identity" Version="2.2.0" />

(2) dotnet run error at program.cs line 17
Https error. #9195:  https://github.com/aspnet/Docs/issues/9195

(1)
You have to use AddIdentity or AddIdentityCore instead of AddDefaultIdentity if you want the default UI off completely.
https://stackoverflow.com/questions/50802781/where-are-the-login-and-register-pages-in-an-aspnet-core-scaffolded-app
_Layout.cshtml:
  <nav class="navbar navbar-inverse navbar-fixed-top">
   
_LoginPartial.cshtml:  
<li class="nav-item">
        <a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Register">Register</a>
    </li>
Dt 15-12-18
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-2.1&tabs=netcore-cli
 */