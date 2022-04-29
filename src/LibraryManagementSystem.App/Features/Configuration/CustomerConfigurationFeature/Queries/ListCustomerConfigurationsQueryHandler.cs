using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Queries
{
    public class ListCustomerConfigurationsQueryHandler : IListQueryHandler<ListCustomerConfigurationsQuery, CustomerConfigurationDto>
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public ListCustomerConfigurationsQueryHandler(BookStoreContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IPagedList<CustomerConfigurationDto>> Handle(ListCustomerConfigurationsQuery request, CancellationToken cancellationToken)
        {
            var customerConfiguration = _context.CustomerConfigurations
                .AsNoTracking()
                .Where(x => !x.IsDeleted);
            var customerConfigurationDto = customerConfiguration.ProjectTo<CustomerConfigurationDto>(_mapper.ConfigurationProvider);
            var response = await customerConfigurationDto.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}