using BookStoreManagementSystem.App.Domain.Seedwork;
using MediatR;

namespace BookStoreManagementSystem.App.Configuration.Mediator
{
    public interface IListQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, IPagedList<TResponse>>
        where TRequest : ListQuery<TResponse>
    {
    }
}