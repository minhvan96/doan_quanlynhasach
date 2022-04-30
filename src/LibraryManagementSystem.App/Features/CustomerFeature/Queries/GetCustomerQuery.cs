using BookStoreManagementSystem.App.Features.CustomerFeature.Dtos;
using MediatR;

namespace BookStoreManagementSystem.App.Features.CustomerFeature.Queries
{
    public class GetCustomerQuery : IRequest<CustomerDto?>
    {
        public Guid Id { get; set; }
    }
}