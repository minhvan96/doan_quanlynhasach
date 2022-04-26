using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.CustomerFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.CustomerFeature.Queries
{
    internal class ListCustomersQueryHandler : IListQueryHandler<ListCustomersQuery, CustomerDto>
    {
        private readonly BookStoreContext _context;

        public ListCustomersQueryHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IPagedList<CustomerDto>> Handle(ListCustomersQuery request, CancellationToken cancellationToken)
        {
            var customer = _context.Customers
                .Where(x => !x.IsDeleted)
                .Select(x => new CustomerDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    FullName = x.FullName,
                    Address = x.Address,
                    BirthDate = x.BirthDate,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber
                });

            if (!string.IsNullOrWhiteSpace(request.FullName))
            {
                customer = customer.Where(x => x.FullName.Contains(request.FullName));
            }

            var response = await customer.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}