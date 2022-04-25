using BookStoreManagementSystem.App.Features.BookFeature.Queries;
using MediatR;

namespace BookStoreManagementSystem
{
    public partial class BookStoreUI : Form
    {
        private readonly IMediator _mediator;

        public BookStoreUI(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private async void searchBoxButton_Click(object sender, EventArgs e)
        {
            var listBookRequest = new ListBooksQuery();
            var books = await _mediator.Send(listBookRequest);
            bookQuery_ListBooks.Rows.Clear();
            foreach (var book in books.Items)
            {
                var bookInfo = new DataGridViewRow();
                bookInfo.CreateCells(bookQuery_ListBooks);
                bookInfo.Cells[0].Value = book.Name;
                bookInfo.Cells[1].Value = book.Code;
                bookInfo.Cells[2].Value = book.TypeName;
                bookInfo.Cells[3].Value = book.AuthorName;
                bookInfo.Cells[4].Value = book.Price + " VNĐ";
                bookQuery_ListBooks.Rows.Add(bookInfo);
            }
        }

        private void StaffInfo_SearchStaff_Search_Button_Click(object sender, EventArgs e)
        {
        }
    }
}