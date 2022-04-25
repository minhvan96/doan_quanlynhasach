using BookStoreManagementSystem.App.Domain.Seedwork;
using MediatR;

namespace BookStoreManagementSystem.App.Configuration.Mediator
{
    public class ListQuery<TResponse> : IRequest<IPagedList<TResponse>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}