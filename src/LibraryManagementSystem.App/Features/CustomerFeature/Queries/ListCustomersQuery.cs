using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.CustomerFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.CustomerFeature.Queries
{
    public class ListCustomersQuery : ListQuery<CustomerDto>
    {
        public string? FullName { get; set; }
    }
}