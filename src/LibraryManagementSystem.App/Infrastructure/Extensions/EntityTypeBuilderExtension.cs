using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace BookStoreManagementSystem.App.Infrastructure.Extensions
{
    internal static class EntityTypeBuilderExtension
    {
        public static void AppendAndAlsoQueryFilter<T>(
          this EntityTypeBuilder<T> entityTypeBuilder, Expression<Func<T, bool>> expression)
          where T : class
        {
            var parameterType = Expression.Parameter(entityTypeBuilder.Metadata.ClrType);

            var expressionFilter = ReplacingExpressionVisitor.Replace(
                expression.Parameters.Single(), parameterType, expression.Body);

            if (entityTypeBuilder.Metadata.GetQueryFilter() != null)
            {
                var currentQueryFilter = entityTypeBuilder.Metadata.GetQueryFilter();
                var currentExpressionFilter = ReplacingExpressionVisitor.Replace(
                    currentQueryFilter.Parameters.Single(), parameterType, currentQueryFilter.Body);
                expressionFilter = Expression.AndAlso(currentExpressionFilter, expressionFilter);
            }

            var lambdaExpression = Expression.Lambda(expressionFilter, parameterType);
            entityTypeBuilder.HasQueryFilter(lambdaExpression);
        }

        public static void AppendOrQueryFilter<T>(
          this EntityTypeBuilder<T> entityTypeBuilder, Expression<Func<T, bool>> expression)
          where T : class
        {
            var parameterType = Expression.Parameter(entityTypeBuilder.Metadata.ClrType);

            var expressionFilter = ReplacingExpressionVisitor.Replace(
                expression.Parameters.Single(), parameterType, expression.Body);

            if (entityTypeBuilder.Metadata.GetQueryFilter() != null)
            {
                var currentQueryFilter = entityTypeBuilder.Metadata.GetQueryFilter();
                var currentExpressionFilter = ReplacingExpressionVisitor.Replace(
                    currentQueryFilter.Parameters.Single(), parameterType, currentQueryFilter.Body);
                expressionFilter = Expression.Or(currentExpressionFilter, expressionFilter);
            }

            var lambdaExpression = Expression.Lambda(expressionFilter, parameterType);
            entityTypeBuilder.HasQueryFilter(lambdaExpression);
        }
    }
}