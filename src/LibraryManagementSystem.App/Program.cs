using BookStoreManagementSystem.App.Configuration.Database;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Authorization;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookStoreManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            host.MigrateDbContext<BookStoreContext>((context, service) =>
            {
                BookStoreContextSeed.SeedAsync(context).Wait();
            });
            try
            {
                Application.Run(ServiceProvider.GetRequiredService<BookStoreUI>());
            }
            catch (Exception ex)
            {
            }
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IPermission, UserPermission>();
                    services.AddAutoMapper(typeof(Program).Assembly);
                    services.AddMediatR(typeof(Program).Assembly);
                    services.AddDbContext<BookStoreContext>();
                    services.AddTransient<BookStoreUI>();
                });
        }
    }
}