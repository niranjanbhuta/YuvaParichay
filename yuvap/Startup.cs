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
using yuvap.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore.SqlServer ;
using MySql.Data.MySqlClient;
//using Microsoft.EntityFrameworkCore.DbContextFactory; //dt 1-1-19


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

        /*     services.AddDbContext<ApplicationDbContext>(options =>
               //options.UseSqlite
                options.UseSqlServer
                (
                    Configuration.GetConnectionString("DefaultConnection")));
          */  

            // Add configuration for DbContext
            // Use connection string from appsettings.json file

          /*   services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration["AppSettings:ConnectionString"]);
            }); */

        // Alternative was failed! Dt 1-1-19 Commented to Solve problem: Many threads for one context
               // http://elvanydev.com/EF-DbContextFactory/

      /*  // Added in YPContext 
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=192.111.150.72,3306;database=indiafxp_yuvap;user=india_indiafxp;password=Niranjan@123");
      //("server=localhost;database=library;user=user;password=password")    }
      */

              services.AddDbContext<YPContext> (options =>                
                //options.UseSqlite
                options.UseSqlServer
                //options.UseMySql
                (
                    Configuration.GetConnectionString("DefaultConnection")) 
                ); // DefaultConnection //YPDatabase                                        
               // options.UseInMemoryDatabase("YPConnection"
               
                //Try to process data by Sqlite to solve err. Dt 4-1-19
             //   services.AddDbContext<YPContextSqlite>(options =>
             //   options.UseSqlite(
             //       Configuration.GetConnectionString("SqliteConn")));

                // InMemory
              /* 
                services.AddDbContext<YPContextSqlite>(
                options => 
                options.UseInMemoryDatabase("MyInMemoryDatabase")); //, InMemoryDatabaseRoot));
               */
                //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
              
            
          
           

           /*   // MySql, Ref. http://insidemysql.com/wp-content/uploads/2016/12/cnet_aspnetcore_090.png
             services.AddMvc(); 
               services.Add(new ServiceDescriptor(typeof(YPContext), 
                new YPContext(Configuration.GetConnectionString("DefaultConnection")  ) ) );
              2nd example
             // Add framework services.  
            services.AddMvc();  
            services.Add(new ServiceDescriptor(typeof(MusicStoreContext), 
            new MusicStoreContext(Configuration.GetConnectionString("DefaultConnection"))));              
             */
        

        /*  Failed err: unhandled exception occurred  // Dt 1-1-19 Added to Solve problem: Many threads for one context
               // http://elvanydev.com/EF-DbContextFactory/
               // ************************************sql server**********************************************
        // this is like if you had called the AddSqlServerDbContextFactory method.
        services.AddDbContextFactory <YPContext>(builder => builder
        .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
        // .UseLoggerFactory(dbLogger)
        );
        */
            
        /*   // services.AddDefaultIdentity<IdentityUser>()
               // .AddDefaultUI(UIFramework.Bootstrap4) 
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
           // services.AddIdentityCore<IdentityUser>()
           //     .AddDefaultUI(UIFramework.Bootstrap4) 
           //    .AddEntityFrameworkStores<ApplicationDbContext>();
        */



           // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        
/*  Temp: Dont protect admin, Identity has problem Dt 16-12-18 03-30 A.N. Where else implemented?? No. Dont show admin-menu, admin remember url
services.AddMvc()
    .AddRazorPagesOptions(options =>
    {
        options.Conventions.AuthorizePage("/YP/pProcess/Admin");
       // options.Conventions.AuthorizeFolder("/Private");
       // options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
       // options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
    })
    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
    */
    services.AddMvc(); 
                
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

            app.UseDefaultFiles(); //nsb 3-1-19
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseStatusCodePages(); //nsb for err, middleware

            app.UseMvc();
        }
    }
}


/*
Note: 
(13) Foreign Key: http://jiodev.com/aspnet/core/data/ef-rp/migrations
modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
            {
                b.HasOne("ContosoUniversity.Models.Course", "Course")
                    .WithMany("Enrollments")
                    .HasForeignKey("CourseID")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("ContosoUniversity.Models.Student", "Student")
                    .WithMany("Enrollments")
                    .HasForeignKey("StudentID")
                    .OnDelete(DeleteBehavior.Cascade);
            });

(12)
(b)'contains':  
   if (!String.IsNullOrEmpty(searchString))
    {
        studentIQ = studentIQ.Where(s => s.LastName.Contains(searchString)
                               || s.FirstMidName.Contains(searchString));
    }
(a) 'Any': Has Table any data: 
        if (context.Student.Any())
            {
                return;   // DB has been seeded
            } 

(11) Mac Path: Select " Where's content, copy and paste into any editor.  
/Users/admin
(10) Mysql: Change PW: https://innovativethought.net/2007/05/17/resetting-your-forgotten-mysql-password/
  UPDATE user SET Password=PASSWORD('YOUR_PASSWORD') WHERE Host='localhost' AND User='root';
(9) publish SelfContainedDeployment
<PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <RuntimeIdentifiers>win10-x64;osx.10.11-x64</RuntimeIdentifiers>
</PropertyGroup>

dotnet publish -c Release -r win10-x64
dotnet publish -c Release -r osx.10.11-x64

Once publish is completed, you will be able to see the files under publish folder.
SampleApp (yuvap)
 .vscode
  bin 
    debug
    Release
      netcoreapp2.0
        OSX.10-x64
        win10-x64
Controllers
Models
Obj
Views
wwwroot

dotnet publish - Windows Explorer

If you navigate to the win10-x64 folder, you will be able to see an executable - yourappname.exe 
(in my case it is SampleApp.exe), 
you can double click on it to start the application. You can zip the folder and deploy it or 
you can copy the contents of the folder and deploy it in the server.

(8) MySql Ref. https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html
err: InvalidOperationException: Services for database providers 'Pomelo.EntityFrameworkCore.MySql', 'MySql.Data.EntityFrameworkCore' 
have been registered in the service provider. Only a single database provider can be registered in a service provider. 
If possible, ensure that Entity Framework is managing its service provider by removing the call to UseInternalServiceProvider. 
Otherwise, consider conditionally registering the database provider, or maintaining one service provider per database provider.

Modified for ver 2.1
<ItemGroup>
    <PackageReference Include="EFCore.DbContextFactory" Version="1.0.2" />
    <PackageReference Include="Microsoft.AspNetCore.All" Version="2.2.0" />
    <PackageReference Include="Microsoft.AspNetCore.App">
      <Version>2.2.0</Version>
    </PackageReference>
    <PackageReference Include="Microsoft.AspNetCore.Razor.Design" Version="2.2.0" PrivateAssets="All" />
    <PackageReference Include="Microsoft.AspNetCore.Razor.Language" Version="2.2.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="2.2.0" />
     <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.2.0" />
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="2.2.0" />
    <PackageReference Include="SqlTableDependency" Version="8.5.3" />       
    
  </ItemGroup>


Removed :- <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="2.1.4" />
    <PackageReference Include="MySql.Data" Version="8.0.13" />
    <PackageReference Include="MySql.Data.EntityFrameworkCore" Version="8.0.13" />
    <PackageReference Include="MySql.Data.EntityFrameworkCore.Design" Version="8.0.13" />
   Sqlite also



(7a) Sql server
https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings
ASP.NET Core
In ASP.NET Core the configuration system is very flexible, and the connection string could be stored in appsettings.json, an environment variable, the user secret store, or another configuration source. See the Configuration section of the ASP.NET Core documentation for more details. The following example shows the connection string stored in appsettings.json.

Data Source=.\MSSQLSERVER2012;Integrated Security=False;User ID=indiafxp_yuvap;Connect Timeout=15;Encrypt=False;Packet Size=4096

"ConnectionStrings": {
    "YPDatabase": "Server=192.111.150.72,1433; Database=indiafxp_yuvap;User Id=indiafxp_yuvap;Password=Yuvap@123;MultipleActiveResultSets=true"   
  }  // OK


{
  "ConnectionStrings": {
    "BloggingDatabase": "Server=(localdb)\\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;"
  },
}
The context is typically configured in Startup.cs with the connection string being read from configuration. Note the GetConnectionString() method looks for a configuration value whose key is ConnectionStrings:<connection string name>. You need to import the Microsoft.Extensions.Configuration namespace to to use this extension method.


public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<BloggingContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase")));
}

(7) SqlServer DB
https://www.codeproject.com/Articles/1264219/%2FArticles%2F1264219%2FCreating-Web-API-in-ASP-NET-Core-2-0
 // Add configuration for DbContext
            // Use connection string from appsettings.json file
            services.AddDbContext<WideWorldImportersDbContext>(options =>
            {
                options.UseSqlServer(Configuration["AppSettings:ConnectionString"]);
            });


Before you run Web API project, add the connection string in appsettings.json file:

{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "AppSettings": {
    "ConnectionString": "server=(local);database=WideWorldImporters;integrated security=yes;"
  }
}            

(6a) Dump:
By Kruti -
"ConnectionStrings": {
    "DefaultConnection": "DataSource=app.db",
    "ApplicationDbContextConnection": "Server=MSSQLSERVER2012/192.111.150.72;Database=indiafxp_yuvap;User Id=indiafxp_yuvap;Password=Yuvap@123;MultipleActiveResultSets=true",
    "yuvapIdentityDbContextConnection": "Server=MSSQLSERVER2012/192.111.150.72;Database=indiafxp_yuvap;User Id=indiafxp_yuvap;Password=Yuvap@123;MultipleActiveResultSets=true"
  }


  "ConnectionStrings": {
    "YPDatabase": "Server=indiafxp_yuvap.yuvaparichay.indiafirst.co.in ;Database=indiafxp_yuvap;User Id=indiafxp_yuvap;Password=Yuvap@123;MultipleActiveResultSets=true"
     },

Database from yuvaparichay.somee.com //OK
 "ConnectionStrings": {
    "YPDatabase": "Server=yuvapSql.mssql.somee.com ;Database=yuvapSql;User Id=pratibhabhuta_SQLLogin_1;Password=7l7edm849m;MultipleActiveResultSets=true"
     }

      "YPDatabase": "Data Source=192.111.150.72;Integrated Security=False;User ID=indiafxp_yuvap;Connect Timeout=15;Encrypt=False;Packet Size=4096"
  err: login failed for user indiafxp_yuvap
 
vkapim@gmail.com

Path = /Users/admin/NSB

(6)Publish: dotnet publish
The main options are --output (or -o) and --configuration (or -c). You need to specify a location for the files generated by the publish operation and you should specify that the published application is compiled or built in Release mode. The following example results in the application being published to a local folder in release mode:
Use Fiezilla
dotnet publish -o c:\publish\myApp -c release
Publishing to a local folder is the only option provided by the CLI commands. Most often, you will use FTP or a similar tool to transfer the published output to the hosting location.


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