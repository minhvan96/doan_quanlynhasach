using MediatR;

namespace BookStoreManagementSystem.App.Features.BookStoreFeature.Commands
{
    public class ImportBookCommand : IRequest<ImportBookResult>
    {
        public Guid BookStoreId { get; set; }
        public ImportBookRequest Request { get; set; } = new ImportBookRequest();
    }

    public class ImportBookRequest
    {
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
    }

    public class ImportBookResult
    {
        public string Message { get; set; } = string.Empty;
        public ImportBookStatus Status { get; set; }
    }

    public enum ImportBookStatus
    {
        ConfigurationNotFound,
        BookStoreNotFound,
        InsufficientNumberOfBookImport,
        ExceedMaximumStock,
        Success
    }
}