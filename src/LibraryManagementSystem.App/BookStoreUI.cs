using BookStoreManagementSystem.App.Features.AuthorFeature.Queries;
using BookStoreManagementSystem.App.Features.BookFeature.Commands;
using BookStoreManagementSystem.App.Features.BookFeature.Queries;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Commands;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Queries;
using BookStoreManagementSystem.App.Features.CustomerFeature.Queries;
using BookStoreManagementSystem.App.Features.IdentityFeature.Commands;
using BookStoreManagementSystem.App.Features.StaffFeature.Queries;
using BookStoreManagementSystem.App.Infrastructure.Authorization;
using MediatR;
using System.Data;

namespace BookStoreManagementSystem
{
    public partial class BookStoreUI : Form
    {
        private readonly IMediator _mediator;
        private readonly IPermission _userPermission;
        private readonly List<TabPage> _managerLevelTab;

        public BookStoreUI(IMediator mediator, IPermission userPermission)
        {
            InitializeComponent();
            _mediator = mediator;
            _userPermission = userPermission;
            _managerLevelTab = new List<TabPage>();
            InitAuthorizedTab();
            DisableUnauthorizedTabs();
        }

        private void InitAuthorizedTab()
        {
            switch (MainNav.TabIndex)
            {
                case 0:
                    break;

                case 1:
                    _managerLevelTab.Add(MainNav.TabPages[1]);
                    break;

                case 2:
                    _managerLevelTab.Add(MainNav.TabPages[2]);
                    break;

                case 3:
                    _managerLevelTab.Add(MainNav.TabPages[3]);
                    break;

                case 4:
                    _managerLevelTab.Add(MainNav.TabPages[4]);
                    break;

                case 5:
                    _managerLevelTab.Add(MainNav.TabPages[5]);
                    break;
            }
        }

        private void DisableUnauthorizedTabs()
        {
            foreach (TabPage tab in _managerLevelTab)
            {
                if (!_userPermission.UserRoles.Contains("manager"))
                {
                    tab.Enabled = false;
                }
                else
                {
                    tab.Enabled = true;
                }
            }
        }

        private async void BookStoreUILoad(object sender, EventArgs e)
        {
            #region QUERY BOOK

            #region Load BookTypes

            var listBookTypesQuery = new ListBookTypesQuery();
            var bookTypes = await _mediator.Send(listBookTypesQuery);

            var bookTypesDataTable = new DataTable();
            var bookTypeIdColumn = new DataColumn("Id", typeof(Guid));
            var bookTypeNameColumn = new DataColumn("Name", typeof(string));
            var bookTypesDataTableAllTypes = bookTypesDataTable;

            bookTypesDataTable.Columns.Add(bookTypeIdColumn);
            bookTypesDataTable.Columns.Add(bookTypeNameColumn);
            bookTypesDataTableAllTypes.Rows.Add(Guid.Empty, "Tất cả thể loại");
            foreach (var bookType in bookTypes.Items)
            {
                bookTypesDataTable.Rows.Add(bookType.Id, bookType.Name);
            }
            QueryBook_BookType_ComboBox.DataSource = bookTypesDataTableAllTypes;
            QueryBook_BookType_ComboBox.DisplayMember = "Name";
            QueryBook_BookType_ComboBox.ValueMember = "Id";

            QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.DataSource = bookTypesDataTable;
            QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.DisplayMember = "Name";
            QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.ValueMember = "Id";

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

        private async void QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton_Click(object sender, EventArgs e)
        {
            #region Validate

            string errorTitle = "Error";
            if (string.IsNullOrWhiteSpace(QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox.Text))
            {
                string message = "Yêu cầu nhập tên sách";
                MessageBox.Show(message, errorTitle);
                return;
            }
            if ((Guid)QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.SelectedValue == Guid.Empty)
            {
                string message = "Yêu cầu chọn loại sách";
                MessageBox.Show(message, errorTitle);
                return;
            }
            if ((Guid)QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.SelectedValue == Guid.Empty)
            {
                string message = "Yêu cầu chọn tác giả";
                MessageBox.Show(message, errorTitle);
                return;
            }
            if (string.IsNullOrWhiteSpace(QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook.Text))
            {
                string message = "Yêu cầu nhập giá";
                MessageBox.Show(message, errorTitle);
                return;
            }

            #endregion Validate

            var createNewBookRequest = new CreateBookRequest
            {
                Name = QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox.Text,
                TypeId = (Guid)QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.SelectedValue,
                AuthorId = (Guid)QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.SelectedValue,
                Price = decimal.Parse(QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook.Text)
            };
            var createNewBookCommand = new CreateBookCommand
            {
                Request = createNewBookRequest
            };
            var createNewBookResult = await _mediator.Send(createNewBookCommand);
            if (createNewBookResult)
            {
                string successfulTitle = "Tạo mới sách thành công";
                string message = "Thêm sách thành công";
                MessageBox.Show(message, successfulTitle);
            }
        }

        private async void ImportBookMenu_QueryBook_SubmitButton_Click(object sender, EventArgs e)
        {
            var bookId = (Guid)ImportBookMenu_QueryBook_BookNameComboBox.SelectedValue;
            var bookStoreId = (Guid)ImportBookMenu_QueryBook_BookStore_ComboBox.SelectedValue;
            var importQuantity = (int)ImportBookMenu_QueryBook_ImportQuantityNum.Value;
            if (bookId == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn sách", "Lỗi nhập sách");
                return;
            }
            if (bookStoreId == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhà sách", "Lỗi nhập sách");
                return;
            }
            if (importQuantity == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng nhập sách", "Lỗi nhập sách");
                return;
            }
            var importBookCommand = new ImportBookCommand
            {
                BookStoreId = bookStoreId,
                Request = new ImportBookRequest
                {
                    BookId = bookId,
                    Quantity = importQuantity
                }
            };
            var importBookResult = await _mediator.Send(importBookCommand);

            if (importBookResult.Status == ImportBookStatus.Success)
            {
                MessageBox.Show(importBookResult.Message, "Nhập sách thành công");
                await ImportBookMenuBookStoreUpdateBooksDataGridView();
            }
            else
            {
                MessageBox.Show(importBookResult.Message, "Lỗi nhập sách");
            }
        }

        private async void ImportBookMenu_QueryBook_BookStore_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ImportBookMenuBookStoreUpdateBooksDataGridView();
        }

        private async Task ImportBookMenuBookStoreUpdateBooksDataGridView()
        {
            try
            {
                var bookStoreId = (Guid)ImportBookMenu_QueryBook_BookStore_ComboBox.SelectedValue;
                ImportBookMenu_BooksDataGridView.Rows.Clear();

                if (bookStoreId != Guid.Empty)
                {
                    var getBookStoreStorageQuery = new GetBookStoreStorageQuery
                    {
                        BookStoreId = bookStoreId,
                    };
                    var bookStoreStorage = await _mediator.Send(getBookStoreStorageQuery);
                    foreach (var bookStorage in bookStoreStorage.Items)
                    {
                        var info = new DataGridViewRow();
                        info.CreateCells(ImportBookMenu_BooksDataGridView);
                        info.Cells[0].Value = bookStorage.BookName;
                        info.Cells[1].Value = bookStorage.BookCode;
                        info.Cells[2].Value = bookStorage.BookTypeName;
                        info.Cells[3].Value = bookStorage.Availability;
                        ImportBookMenu_BooksDataGridView.Rows.Add(info);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void ImportBookTab_Enter(object sender, EventArgs e)
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
            bookStoreDataTable.Rows.Add(Guid.Empty, "Chọn nhà sách");

            foreach (var bookStore in bookStores.Items)
            {
                bookStoreDataTable.Rows.Add(bookStore.Id, bookStore.Name);
            }
            ImportBookMenu_QueryBook_BookStore_ComboBox.DataSource = bookStoreDataTable;
            ImportBookMenu_QueryBook_BookStore_ComboBox.DisplayMember = "Name";
            ImportBookMenu_QueryBook_BookStore_ComboBox.ValueMember = "Id";

            #endregion Load BookStores

            #region Load Books

            var listBooksQuery = new ListBooksQuery();
            var books = await _mediator.Send(listBooksQuery);
            var booksDataTable = new DataTable();
            var bookIdColumn = new DataColumn("Id", typeof(Guid));
            var bookNameColumn = new DataColumn("Name", typeof(string));
            booksDataTable.Columns.Add(bookIdColumn);
            booksDataTable.Columns.Add(bookNameColumn);
            booksDataTable.Rows.Add(Guid.Empty, "Chọn sách");
            foreach (var book in books.Items)
            {
                booksDataTable.Rows.Add(book.Id, book.Name);
            }

            ImportBookMenu_QueryBook_BookNameComboBox.DataSource = booksDataTable;
            ImportBookMenu_QueryBook_BookNameComboBox.DisplayMember = "Name";
            ImportBookMenu_QueryBook_BookNameComboBox.ValueMember = "Id";

            #endregion Load Books

            #endregion IMPORT BOOK
        }

        private async void HomeTab_LoginContainer_LoginButton_Click(object sender, EventArgs e)
        {
            var userName = HomeTab_LoginContainer_UserNameTextBox.Text;
            var userPassword = HomeTab_LoginContainer_PasswordTextBook.Text;
            var errorTitle = "Lỗi đăng nhập";
            if (string.IsNullOrWhiteSpace(userName))
            {
                string message = "Yêu cầu nhập tên đăng nhập";
                MessageBox.Show(message, errorTitle);
                return;
            }
            if (string.IsNullOrWhiteSpace(userPassword))
            {
                string message = "Yêu cầu nhập mật khẩu";
                MessageBox.Show(message, errorTitle);
                return;
            }
            var loginCommand = new LoginCommand
            {
                Request = new LoginRequest
                {
                    UserName = userName,
                    Password = userPassword
                }
            };
            var user = await _mediator.Send(loginCommand);

            if (user == null)
            {
                string message = "Tên đăng nhập hoặc tài khoản không đúng";
                MessageBox.Show(message, errorTitle);
                return;
            }
            _userPermission.UserRoles.Clear();
            _userPermission.UserRoles.AddRange(user.Roles);
            DisableUnauthorizedTabs();
        }

        private void ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}