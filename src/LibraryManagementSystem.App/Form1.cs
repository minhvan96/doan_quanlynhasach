using BookStoreManagementSystem.App.Features.BookFeature.Queries;
using MediatR;

namespace BookStoreManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly IMediator _mediator;

        public Form1(IMediator mediator)
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
                bookInfo.Cells[1].Value = "";
                bookInfo.Cells[2].Value = book.TypeName;
                bookInfo.Cells[3].Value = book.AuthorName;
                bookInfo.Cells[4].Value = "100000";
                bookQuery_ListBooks.Rows.Add(bookInfo);
            }
        }
    }
}