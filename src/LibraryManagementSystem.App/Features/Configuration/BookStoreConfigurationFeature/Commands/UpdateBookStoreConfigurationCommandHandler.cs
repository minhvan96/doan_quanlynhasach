using BookStoreManagementSystem.App.Infrastructure;
using MediatR;

namespace BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Commands
{
    public class UpdateBookStoreConfigurationCommandHandler : IRequestHandler<UpdateBookStoreConfigurationCommand, UpdateBookStoreConfigurationCommandStatus>
    {
        private readonly BookStoreContext _context;

        public UpdateBookStoreConfigurationCommandHandler(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<UpdateBookStoreConfigurationCommandStatus> Handle(UpdateBookStoreConfigurationCommand request, CancellationToken cancellationToken)
        {
            var configuration = await _context.BookStoreConfigurations
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (configuration == null)
                return UpdateBookStoreConfigurationCommandStatus.ConfigurationNotFound;

            configuration.Update(request.Name, request.MaximumStock, request.MinimumStock, request.MinimumImportBook);
            await _context.SaveChangesAsync(cancellationToken);
            return UpdateBookStoreConfigurationCommandStatus.Success;
        }
    }
}