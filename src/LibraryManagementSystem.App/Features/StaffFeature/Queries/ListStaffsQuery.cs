using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Features.StaffFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.StaffFeature.Queries
{
    public class ListStaffsQuery : ListQuery<StaffDto>
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}