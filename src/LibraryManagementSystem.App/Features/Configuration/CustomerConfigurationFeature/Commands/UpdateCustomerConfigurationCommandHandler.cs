using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Commands
{
    public class UpdateCustomerConfigurationCommandHandler : IRequestHandler<UpdateCustomerConfigurationCommand, UpdateCustomerConfigurationCommandStatus>
    {
        private readonly BookStoreContext _context;

        public UpdateCustomerConfigurationCommandHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<UpdateCustomerConfigurationCommandStatus> Handle(UpdateCustomerConfigurationCommand request, CancellationToken cancellationToken)
        {
            var configuration = await _context.CustomerConfigurations
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (configuration == null)
                return UpdateCustomerConfigurationCommandStatus.ConfigurationNotFound;

            configuration.Update(request.Name, request.MaximumDebt);
            await _context.SaveChangesAsync(cancellationToken);
            return UpdateCustomerConfigurationCommandStatus.Success;
        }
    }
}