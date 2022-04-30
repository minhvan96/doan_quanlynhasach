using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _mapper;

        public ListCustomersQueryHandler(BookStoreContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IPagedList<CustomerDto>> Handle(ListCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = _context.Customers
                .Include(x => x.Debt)
                .Where(x => !x.IsDeleted);

            if (!string.IsNullOrWhiteSpace(request.FullName))
            {
                customers = customers.Where(x => x.FullName.Contains(request.FullName));
            }
            var customersDto = customers.ProjectTo<CustomerDto>(_mapper.ConfigurationProvider);
            var response = await customersDto.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}