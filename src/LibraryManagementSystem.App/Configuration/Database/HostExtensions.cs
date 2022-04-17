using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Polly;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public static class HostExtensions
    {
        public static IHost MigrateDbContext<TDbContext>(this IHost host, Action<TDbContext, IServiceProvider> seeder)
            where TDbContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<TDbContext>>();
                var context = services.GetService<TDbContext>();
                if (context == null)
                    return host;
                try
                {
                    logger.LogInformation("Migrating database associated with context {DbContextName}", typeof(TDbContext).Name);

                    var retries = 10;
                    var retry = Policy.Handle<Microsoft.Data.SqlClient.SqlException>()
                        .WaitAndRetry(
                            retryCount: retries,
                            sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                            onRetry: (exception, timeSpan, retry, ctx) =>
                            {
                                logger.LogWarning(exception, "[{prefix}] Exception {ExceptionType} with message {Message} detected on attempt {retry} of {retries}",
                                    nameof(TDbContext),
                                    exception.GetType().Name,
                                    exception.Message,
                                    retry,
                                    retries);
                            });
                    if (seeder != null)
                    {
                        retry.Execute(() => InvokeSeeder(seeder, context, services));
                    }

                    logger.LogInformation("Migrated database associated with context {DbContextName}", typeof(TDbContext).Name);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while migrating the database used on context {DbContextName}", typeof(TDbContext).Name);
                }
            }
            return host;
        }

        private static void InvokeSeeder<TDbContext>(Action<TDbContext, IServiceProvider> seeder, TDbContext context, IServiceProvider services)
            where TDbContext : DbContext
        {
            context.Database.Migrate();
            seeder(context, services);
        }
    }
}