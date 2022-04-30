using AutoMapper;
using BookStoreManagementSystem.App.Features.CustomerFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.CustomerFeature.Queries
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, CustomerDto?>
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public GetCustomerQueryHandler(BookStoreContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomerDto?> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers
                .AsNoTracking()
                .Include(x => x.Debt)
                .Where(x => !x.IsDeleted && x.Id == request.Id)
                .FirstOrDefaultAsync(cancellationToken);

            var customerDto = _mapper.Map<CustomerDto>(customer);
            return customerDto;
        }
    }
}