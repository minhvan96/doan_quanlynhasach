﻿using BookStoreManagementSystem.App.Features.AuthorFeature.Queries;
using BookStoreManagementSystem.App.Features.BookFeature.Queries;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Queries;
using BookStoreManagementSystem.App.Features.CustomerFeature.Queries;
using BookStoreManagementSystem.App.Features.StaffFeature.Queries;
using MediatR;
using System.Data;

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

        private async void BookStoreUILoad(object sender, EventArgs e)
        {
            #region IMPORT BOOK

            #region Load BookStores

            var listBookStores = new ListBookStoresQuery();
            var bookStores = await _mediator.Send(listBookStores);
            var bookStoreDataTable = new DataTable();
            var bookStoreIdColumn = new DataColumn("Id", typeof(Guid));
            var bookStoreNameColumn = new DataColumn("Name", typeof(string));
            bookStoreDataTable.Columns.Add(bookStoreIdColumn);
            bookStoreDataTable.Columns.Add(bookStoreNameColumn);
            foreach (var bookStore in bookStores.Items)
            {
                bookStoreDataTable.Rows.Add(bookStore.Id, bookStore.Name);
            }
            ImportBookMenu_QueryBook_BookStore_ComboBox.DataSource = bookStoreDataTable;
            ImportBookMenu_QueryBook_BookStore_ComboBox.DisplayMember = "Name";
            ImportBookMenu_QueryBook_BookStore_ComboBox.ValueMember = "Id";

            #endregion Load BookStores

            #endregion IMPORT BOOK

            #region QUERY BOOK

            #region Load BookTypes

            var listBookTypesQuery = new ListBookTypesQuery();
            var bookTypes = await _mediator.Send(listBookTypesQuery);

            var bookTypesDataTable = new DataTable();
            var bookTypeIdColumn = new DataColumn("Id", typeof(Guid));
            var bookTypeNameColumn = new DataColumn("Name", typeof(string));

            bookTypesDataTable.Columns.Add(bookTypeIdColumn);
            bookTypesDataTable.Columns.Add(bookTypeNameColumn);
            bookTypesDataTable.Rows.Add(Guid.Empty, "Tất cả thể loại");
            foreach (var bookType in bookTypes.Items)
            {
                bookTypesDataTable.Rows.Add(bookType.Id, bookType.Name);
            }
            QueryBook_BookType_ComboBox.DataSource = bookTypesDataTable;
            QueryBook_BookType_ComboBox.DisplayMember = "Name";
            QueryBook_BookType_ComboBox.ValueMember = "Id";

            #endregion Load BookTypes

            #region Load BookPrice

            var bookPriceRangeDataTable = new DataTable();
            var bookPriceIdColumn = new DataColumn("Id", typeof(QueryBookPriceRange));
            var bookPriceTypeNameColumn = new DataColumn("Name", typeof(string));
            bookPriceRangeDataTable.Columns.Add(bookPriceIdColumn);
            bookPriceRangeDataTable.Columns.Add(bookPriceTypeNameColumn);
            bookPriceRangeDataTable.Rows.Add(QueryBookPriceRange.All, "Tất cả giá");
            bookPriceRangeDataTable.Rows.Add(QueryBookPriceRange.LessThan50K, "Dưới 50.000 VNĐ");
            bookPriceRangeDataTable.Rows.Add(QueryBookPriceRange.From50kTo100K, "50.000 - 100.000 VNĐ");
            bookPriceRangeDataTable.Rows.Add(QueryBookPriceRange.From100kTo500K, "100.000 - 500.000 VNĐ");
            bookPriceRangeDataTable.Rows.Add(QueryBookPriceRange.From500kTo1M, "500.000 - 1.000.000 VNĐ");
            bookPriceRangeDataTable.Rows.Add(QueryBookPriceRange.GreaterThan1M, "Trên 1.000.000 VNĐ");
            QueryBook_Price_ComboBox.DataSource = bookPriceRangeDataTable;
            QueryBook_Price_ComboBox.DisplayMember = "Name";
            QueryBook_Price_ComboBox.ValueMember = "Id";

            #endregion Load BookPrice

            #region Load Author

            var authorsDataTale = new DataTable();
            var authorIdColumn = new DataColumn("Id", typeof(Guid));
            var authorNameColumn = new DataColumn("Name", typeof(string));
            authorsDataTale.Columns.Add(authorIdColumn);
            authorsDataTale.Columns.Add(authorNameColumn);

            var listAuthorsQuery = new ListAuthorsQuery();
            var authors = await _mediator.Send(listAuthorsQuery);
            foreach (var author in authors.Items)
            {
                authorsDataTale.Rows.Add(author.Id, author.Name);
            }
            QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.DataSource = authorsDataTale;
            QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.DisplayMember = "Name";
            QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.ValueMember = "Id";

            #endregion Load Author

            #endregion QUERY BOOK
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

        private async void CustomerMenu_QueryCustomer_Search_Button_Click(object sender, EventArgs e)
        {
            var listCustomersRequest = new ListCustomersQuery();
            if (!string.IsNullOrEmpty(CustomerMenu_QueryCustomer_FullName_Textbox.Text))
            {
                listCustomersRequest.FullName = CustomerMenu_QueryCustomer_FullName_Textbox.Text;
            }

            var customers = await _mediator.Send(listCustomersRequest);
            CustomerMenu_QueryCustomer_CustomerDataGridView.Rows.Clear();

            foreach (var customer in customers.Items)
            {
                var customerInfo = new DataGridViewRow();
                customerInfo.CreateCells(CustomerMenu_QueryCustomer_CustomerDataGridView);
                customerInfo.Cells[0].Value = customer.Id;
                customerInfo.Cells[1].Value = customer.FullName;
                customerInfo.Cells[2].Value = customer.Address;
                customerInfo.Cells[3].Value = customer.PhoneNumber;
                CustomerMenu_QueryCustomer_CustomerDataGridView.Rows.Add(customerInfo);
            }
        }

        private async void QueryBookMenu_BookInfo_SearchBook_Button_Click(object sender, EventArgs e)
        {
            var listBookRequest = new ListBooksQuery();
            if (!string.IsNullOrWhiteSpace(QueryBook_BookName_TextBox.Text))
            {
                listBookRequest.BookName = QueryBook_BookName_TextBox.Text;
            }
            if (!string.IsNullOrWhiteSpace(QueryBook_AuthorName_TextBox.Text))
            {
                listBookRequest.AuthorName = QueryBook_AuthorName_TextBox.Text;
            }
            if (!string.IsNullOrWhiteSpace(QueryBook_BookCode_TextBox.Text))
            {
                listBookRequest.BookCode = QueryBook_BookCode_TextBox.Text;
            }
            var bookTypeId = (Guid)QueryBook_BookType_ComboBox.SelectedValue;
            if (bookTypeId != Guid.Empty)
            {
                listBookRequest.BookType = bookTypeId;
            }
            var bookPriceRange = (QueryBookPriceRange)QueryBook_Price_ComboBox.SelectedValue;
            if (bookPriceRange == QueryBookPriceRange.None || bookPriceRange != QueryBookPriceRange.All)
            {
                listBookRequest.Price = bookPriceRange;
            }

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
    }
}