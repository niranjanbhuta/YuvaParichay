// nsb Dt 1-1-19 Ref. https://github.com/vany0114/EF.DbContextFactory

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace  yuvap //EFCore.DbContextFactory.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configures the resolution of <typeparamref name="TDataContext"/>'s factory.
        /// </summary>
        /// <typeparam name="TDataContext">The DbContext.</typeparam>
        /// <param name="services"></param>
        /// <param name="nameOrConnectionString">Name or connection string of the context. (Optional)</param>
        /// <param name="logger">The <see cref="ILoggerFactory" implementation./></param>
        public static void AddSqlServerDbContextFactory<TDataContext>(this IServiceCollection services, string nameOrConnectionString = null, ILoggerFactory logger = null)
            where TDataContext : DbContext
        {
            if (string.IsNullOrEmpty(nameOrConnectionString))
            {
                var serviceProvider = services.BuildServiceProvider();
                var configuration = serviceProvider.GetService<IConfiguration>();
                nameOrConnectionString = configuration.GetConnectionString("DefaultConnection");
            }

            AddDbContextFactory<TDataContext>(services, (provider, builder) =>
                builder.UseSqlServer(nameOrConnectionString)
                    .UseLoggerFactory(logger)
            );
        }

        /// <summary>
        /// Configures the resolution of <typeparamref name="TDataContext"/>'s factory.
        /// </summary>
        /// <typeparam name="TDataContext">The DbContext.</typeparam>
        /// <param name="services"></param>
        /// <param name="options">The DbContext options.</param>
        public static void AddDbContextFactory<TDataContext>(this IServiceCollection services,
            Action<DbContextOptionsBuilder> options)
            where TDataContext : DbContext
            => AddDbContextFactory<TDataContext>(services, (provider, builder) => options.Invoke(builder));

        /// <summary>
        /// Configures the resolution of <typeparamref name="TDataContext"/>'s factory.
        /// </summary>
        /// <typeparam name="TDataContext">The DbContext.</typeparam>
        /// <param name="services"></param>
        /// <param name="optionsAction">Service provider and DbContext options.</param>
        public static void AddDbContextFactory<TDataContext>(this IServiceCollection services, Action<IServiceProvider, DbContextOptionsBuilder> optionsAction)
            where TDataContext : DbContext
        {
            AddCoreServices<TDataContext>(services, optionsAction, ServiceLifetime.Scoped);
            var serviceProvider = services.BuildServiceProvider();
            var options = serviceProvider.GetService<DbContextOptions<TDataContext>>();

            services.AddScoped<Func<TDataContext>>(ctx =>
            {
                return () => (TDataContext)Activator.CreateInstance(typeof(TDataContext), options);
            });
        }

        private static void AddCoreServices<TContextImplementation>(
            IServiceCollection serviceCollection,
            Action<IServiceProvider, DbContextOptionsBuilder> optionsAction,
            ServiceLifetime optionsLifetime)
            where TContextImplementation : DbContext
        {
            serviceCollection
                .AddMemoryCache()
                .AddLogging();

            serviceCollection.TryAdd(
                new ServiceDescriptor(
                    typeof(DbContextOptions<TContextImplementation>),
                    p => DbContextOptionsFactory<TContextImplementation>(p, optionsAction),
                    optionsLifetime));

            serviceCollection.Add(
                new ServiceDescriptor(
                    typeof(DbContextOptions),
                    p => p.GetRequiredService<DbContextOptions<TContextImplementation>>(),
                    optionsLifetime));
        }

        private static DbContextOptions<TContext> DbContextOptionsFactory<TContext>(
            IServiceProvider applicationServiceProvider,
            Action<IServiceProvider, DbContextOptionsBuilder> optionsAction)
            where TContext : DbContext
        {
            var builder = new DbContextOptionsBuilder<TContext>(
                new DbContextOptions<TContext>(new Dictionary<Type, IDbContextOptionsExtension>()));

            builder.UseApplicationServiceProvider(applicationServiceProvider);
            optionsAction?.Invoke(applicationServiceProvider, builder);

            return builder.Options;
        }
    }
}







/* //by nsb dt 1-1-19. Ref. http://anthonygiretti.com/2017/12/
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using yuvap.Data;

namespace yuvap
{
    public static class AddDbContextFactoryHelper
    {
        public static void AddDbContextFactory(this IServiceCollection services, string connectionString) where DataContext : DbContext
       // public static void AddDbContextFactory(this IServiceCollection services, string connectionString)  
        {
            // var  DbContext = DataContext();
           //var  DataContext =  DbContext();

            services.AddSingleton<Func>((ctx) => //nsb needs to be changed
            {
                var options = new DbContextOptionsBuilder()
                    .UseSqlServer(connectionString)
                    .Options;

                return () => (DataContext)Activator.CreateInstance(typeof(DataContext), options);
                //return () => (_context)Activator.CreateInstance(typeof(DbContext), options); //nsb
           
            });
        }
    }
}

//nsb implimentation: 
// services.AddDbContextFactory(ConnectionString);
 */         