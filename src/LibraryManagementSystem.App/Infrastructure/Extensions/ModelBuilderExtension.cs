using System.Linq.Expressions;

namespace BookStoreManagementSystem.App.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder EnableFilter<TEntity>(this ModelBuilder builder,
            Expression<Func<TEntity, bool>> expression,
            ApplyFilterMode applyMode = ApplyFilterMode.None)
            where TEntity : class
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            if (applyMode == ApplyFilterMode.And)
            {
                builder.Entity<TEntity>().AppendAndAlsoQueryFilter(expression);
            }
            else if (applyMode == ApplyFilterMode.Or)
            {
                builder.Entity<TEntity>().AppendOrQueryFilter(expression);
            }

            return builder;
        }

        public static ModelBuilder EnableFilter<TEntity>(this ModelBuilder builder,
            Expression<Func<TEntity, bool>> expression,
            ApplyFilterMode applyMode,
            Func<bool> condition)
            where TEntity : class
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            if (condition.Invoke())
            {
                if (applyMode == ApplyFilterMode.And)
                {
                    builder.Entity<TEntity>().AppendAndAlsoQueryFilter(expression);
                }
                else if (applyMode == ApplyFilterMode.Or)
                {
                    builder.Entity<TEntity>().AppendOrQueryFilter(expression);
                }
            }

            return builder;
        }
    }

    public enum ApplyFilterMode
    {
        None,
        And,
        Or
    }
}