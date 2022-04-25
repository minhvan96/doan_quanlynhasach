using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;
using MediatR;

namespace BookStoreManagementSystem.App.Features.BookFeature.Queries
{
    public class ListBooksQuery : IRequest<IPagedList<BookDto>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}