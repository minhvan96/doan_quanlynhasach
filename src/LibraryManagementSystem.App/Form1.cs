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
        }
    }
}