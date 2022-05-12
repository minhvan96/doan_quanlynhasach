using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Authorization;
using MediatR;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Commands
{
    public class ImportBookCommandHandler : IRequestHandler<ImportBookCommand, ImportBookResult>
    {
        private readonly BookStoreContext _context;
        private readonly IPermission _permission;

        public ImportBookCommandHandler(BookStoreContext context, IPermission permission)
        {
            _context = context;
            _permission = permission;
        }

        public async Task<ImportBookResult> Handle(ImportBookCommand request, CancellationToken cancellationToken)
        {
            var staff = await _context.Staffs.FirstOrDefaultAsync(x => x.UserId == _permission.UserId, cancellationToken);
            var staffId = staff?.Id ?? Guid.Empty;
            var bookStore = await _context.BookStores.AnyAsync(x => x.Id == request.BookStoreId && !x.IsDeleted, cancellationToken);
            if (!bookStore)
            {
                return new ImportBookResult
                {
                    Status = ImportBookStatus.BookStoreNotFound,
                    Message = "Thông tin nhà sách không tồn tại"
                };
            }
            var configuration = await _context.BookStoreConfigurations
                .FirstOrDefaultAsync(x => x.Name == "Default", cancellationToken);

            if (configuration == null)
                return new ImportBookResult
                {
                    Message = "Không tìm thấy cấu hình nhập sách",
                    Status = ImportBookStatus.ConfigurationNotFound
                };
            if (configuration.MinimumBookImport > request.Request.Quantity)
                return new ImportBookResult
                {
                    Message = $"Số lượng nhập sách tối thiểu không đủ, yêu cầu nhập ít nhất {configuration.MinimumBookImport} quyển",
                    Status = ImportBookStatus.InsufficientNumberOfBookImport
                };
            var bookStoreStorage = await _context.BookStoresStorage
                .Where(x => x.BookId == request.Request.BookId && x.BookStoreId == request.BookStoreId)
                .FirstOrDefaultAsync(cancellationToken);

            var newInventoryHistory = new InventoryHistory(DateTime.Now.Date, staffId, request.Request.BookId, request.BookStoreId, request.Request.Quantity);
            if (bookStoreStorage == null)
            {
                var newBookStoreStorage = new BookStoreStorage(request.Request.BookId, request.BookStoreId, request.Request.Quantity);
                if (newBookStoreStorage.Availability > configuration.MaximumStock)
                    return new ImportBookResult
                    {
                        Message = $"Số lượng tồn kho vượt quá quy định ({configuration.MaximumStock} quyển)",
                        Status = ImportBookStatus.ExceedMaximumStock
                    };
                _context.Add(newBookStoreStorage);
                _context.Add(newInventoryHistory);
                await _context.SaveChangesAsync(cancellationToken);
                return new ImportBookResult
                {
                    Status = ImportBookStatus.Success,
                    Message = "Nhập sách thành công"
                };
            }

            if (bookStoreStorage.Availability + request.Request.Quantity > configuration.MaximumStock)
                return new ImportBookResult
                {
                    Message = $"Số lượng tồn kho vượt quá quy định ({configuration.MaximumStock} quyển)",
                    Status = ImportBookStatus.ExceedMaximumStock
                };
            bookStoreStorage.Import(request.Request.Quantity);
            _context.Add(newInventoryHistory);
            await _context.SaveChangesAsync(cancellationToken);
            return new ImportBookResult
            {
                Status = ImportBookStatus.Success,
                Message = "Nhập sách thành công"
            };
        }
    }
}