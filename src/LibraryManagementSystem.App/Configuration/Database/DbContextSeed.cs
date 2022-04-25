using Microsoft.Data.SqlClient;
using Polly;
using Polly.Retry;

namespace BookStoreManagementSystem.App.Configuration.Database
{
    public abstract class DbContextSeed : IDbContextSeed
    {
        public static AsyncRetryPolicy CreatePolicy(string prefix, int retries = 3)
        {
            return Policy.Handle<SqlException>().
                WaitAndRetryAsync(
                    retryCount: retries,
                    sleepDurationProvider: retry => TimeSpan.FromSeconds(5),
                    onRetry: (exception, timeSpan, retry, ctx) =>
                    {
                    }
                );
        }
    }
}