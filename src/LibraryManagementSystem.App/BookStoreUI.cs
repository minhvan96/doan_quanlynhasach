using BookStoreManagementSystem.App.Features.BookFeature.Queries;
using BookStoreManagementSystem.App.Features.StaffFeature.Queries;
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

        private async void StaffInfo_SearchStaff_Search_Button_Click(object sender, EventArgs e)
        {
            var listStaffsRequest = new ListStaffsQuery();
            if (!string.IsNullOrEmpty(StaffInfo_SearchStaff_Name_Textbox.Text))
            {
                listStaffsRequest.Name = StaffInfo_SearchStaff_Name_Textbox.Text;
            }
            if (!string.IsNullOrEmpty(StaffInfo_SearchStaff_Age_Textbox.Text))
            {
                listStaffsRequest.Age = int.Parse(StaffInfo_SearchStaff_Age_Textbox.Text);
            }
            var staffs = await _mediator.Send(listStaffsRequest);
            StaffInfo_SearchStaff_StaffInfo_GridTable.Rows.Clear();

            foreach (var staff in staffs.Items)
            {
                var staffInfo = new DataGridViewRow();
                staffInfo.CreateCells(StaffInfo_SearchStaff_StaffInfo_GridTable);
                staffInfo.Cells[0].Value = staff.Name;
                staffInfo.Cells[1].Value = staff.Address;
                staffInfo.Cells[2].Value = staff.Age;
                staffInfo.Cells[3].Value = staff.Position;
                staffInfo.Cells[4].Value = staff.PhoneNumber;
                StaffInfo_SearchStaff_StaffInfo_GridTable.Rows.Add(staffInfo);
            }
        }

        private void bookQuery_ListBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}