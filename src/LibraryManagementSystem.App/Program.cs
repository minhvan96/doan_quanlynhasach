using BookStoreManagementSystem.App.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

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

            var services = new ServiceCollection();
            ConfigureServices(services);
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<Form1>();
            services.AddDbContext<BookStoreContext>();
        }
    }
}