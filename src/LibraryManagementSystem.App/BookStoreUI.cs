using BookStoreManagementSystem.App.Features.AuthorFeature.Queries;
using BookStoreManagementSystem.App.Features.BookFeature.Commands;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;
using BookStoreManagementSystem.App.Features.BookFeature.Queries;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Commands;
using BookStoreManagementSystem.App.Features.BookStoreFeature.Queries;
using BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Commands;
using BookStoreManagementSystem.App.Features.Configuration.BookStoreConfigurationFeature.Queries;
using BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Commands;
using BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Queries;
using BookStoreManagementSystem.App.Features.CustomerFeature.Queries;
using BookStoreManagementSystem.App.Features.IdentityFeature.Commands;
using BookStoreManagementSystem.App.Features.ReceiptFeature.Commands;
using BookStoreManagementSystem.App.Features.ReportFeature.Queries;
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
            _userPermission.UserId = user.Id;
            _userPermission.UserRoles.AddRange(user.Roles);
            DisableUnauthorizedTabs();
        }

        private void ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.SelectedCells[0].RowIndex;
            var configurationId = ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var configurationName = ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var maximumStock = ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows[selectedRowIndex].Cells[2].Value;
            var minimumStock = ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows[selectedRowIndex].Cells[3].Value;
            var minimumImportBook = ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows[selectedRowIndex].Cells[4].Value;
            ConfigurationTab_BookStoreConfigurationTab_ConfigurationIdTextBox.Text = configurationId.ToString();
            ConfigurationTab_BookStoreConfigurationTab_ConfigurationNameTextBox.Text = configurationName.ToString();
            ConfigurationTab_BookStoreConfigurationTab_MaximumStockNumericUpDown.Value = (int)maximumStock;
            ConfigurationTab_BookStoreConfigurationTab_MinimumStockNumericUpDown.Value = (int)minimumStock;
            ConfigurationTab_BookStoreConfigurationTab_MinimumImportBookNumericUpDown.Value = (int)minimumImportBook;
        }

        private async void ConfigurationTab_Enter(object sender, EventArgs e)
        {
            await LoadConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView();
        }

        private async Task LoadConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView()
        {
            var listBookStoreConfigurationsQuery = new ListBookStoreConfigurationsQuery();
            var bookStoreConfigurations = await _mediator.Send(listBookStoreConfigurationsQuery);
            ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows.Clear();
            foreach (var configuration in bookStoreConfigurations.Items)
            {
                var configurationInfo = new DataGridViewRow();
                configurationInfo.CreateCells(ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView);
                configurationInfo.Cells[0].Value = configuration.Id;
                configurationInfo.Cells[1].Value = configuration.Name;
                configurationInfo.Cells[2].Value = configuration.MaximumStock;
                configurationInfo.Cells[3].Value = configuration.MinimumStock;
                configurationInfo.Cells[4].Value = configuration.MinimumBookImport;
                ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Rows.Add(configurationInfo);
            }
        }

        private async void ConfigurationTab_BookStoreConfigurationTab_Submit_Button_Click(object sender, EventArgs e)
        {
            var configurationId = new Guid(ConfigurationTab_BookStoreConfigurationTab_ConfigurationIdTextBox.Text);
            var configurationName = ConfigurationTab_BookStoreConfigurationTab_ConfigurationNameTextBox.Text;
            var maximumStock = (int)ConfigurationTab_BookStoreConfigurationTab_MaximumStockNumericUpDown.Value;
            var minimumStock = (int)ConfigurationTab_BookStoreConfigurationTab_MinimumStockNumericUpDown.Value;
            var minimumImportBook = (int)ConfigurationTab_BookStoreConfigurationTab_MinimumImportBookNumericUpDown.Value;
            var updateBookStoreConfigurationCommand = new UpdateBookStoreConfigurationCommand
            {
                Id = configurationId,
                Name = configurationName,
                MaximumStock = maximumStock,
                MinimumStock = minimumStock,
                MinimumImportBook = minimumImportBook,
            };
            var result = await _mediator.Send(updateBookStoreConfigurationCommand);
            if (result == UpdateBookStoreConfigurationCommandStatus.Success)
            {
                MessageBox.Show("Cập nhật cấu hình thành công", "Cập nhật cấu hình");
                await LoadConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView();
                return;
            }
            MessageBox.Show("Không tìm thấy thông tin cấu hình, vui lòng kiểm tra lại", "Lỗi cập nhật cấu hình");
        }

        private async void ConfigurationTab_CustomerConfigurationTab_Enter(object sender, EventArgs e)
        {
            await LoadConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView();
        }

        private async Task LoadConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView()
        {
            var listCustomerConfigurationsQuery = new ListCustomerConfigurationsQuery();
            var customerConfigurations = await _mediator.Send(listCustomerConfigurationsQuery);
            ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView.Rows.Clear();
            foreach (var configuration in customerConfigurations.Items)
            {
                var configurationInfo = new DataGridViewRow();
                configurationInfo.CreateCells(ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView);
                configurationInfo.Cells[0].Value = configuration.Id;
                configurationInfo.Cells[1].Value = configuration.Name;
                configurationInfo.Cells[2].Value = configuration.MaximumDebt;

                ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView.Rows.Add(configurationInfo);
            }
        }

        private void ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView.SelectedCells[0].RowIndex;
            var configurationId = ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var configurationName = ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var maximumDebt = ConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView.Rows[selectedRowIndex].Cells[2].Value;
            ConfigurationTab_CustomerConfigurationTab_ConfigurationIdTextBox.Text = configurationId.ToString();
            ConfigurationTab_CustomerConfigurationTab_ConfigurationNameTextBox.Text = configurationName.ToString();
            ConfigurationTab_CustomerConfigurationTab_MaximumDebtNumericUpDown.Value = (decimal)maximumDebt;
        }

        private async void ConfigurationTab_CustomerConfigurationTab_SubmitButton_Click(object sender, EventArgs e)
        {
            var configurationId = new Guid(ConfigurationTab_CustomerConfigurationTab_ConfigurationIdTextBox.Text);
            var configurationName = ConfigurationTab_CustomerConfigurationTab_ConfigurationNameTextBox.Text;
            var maximumDebt = ConfigurationTab_CustomerConfigurationTab_MaximumDebtNumericUpDown.Value;
            var updateBookStoreConfigurationCommand = new UpdateCustomerConfigurationCommand
            {
                Id = configurationId,
                Name = configurationName,
                MaximumDebt = maximumDebt
            };
            var result = await _mediator.Send(updateBookStoreConfigurationCommand);
            if (result == UpdateCustomerConfigurationCommandStatus.Success)
            {
                MessageBox.Show("Cập nhật cấu hình thành công", "Cập nhật cấu hình");
                await LoadConfigurationTab_CustomerConfigurationTab_CustomerConfigurationDataGridView();
                return;
            }
            MessageBox.Show("Không tìm thấy thông tin cấu hình, vui lòng kiểm tra lại", "Lỗi cập nhật cấu hình");
        }

        private async void SaleBookTab_Enter(object sender, EventArgs e)
        {
            await LoadSaleBookTab_Pages_AddCustomerPage_CustomersDataGridView();
        }

        private async Task LoadSaleBookTab_Pages_AddCustomerPage_CustomersDataGridView()
        {
            var listCustomersQuery = new ListCustomersQuery();
            var customers = await _mediator.Send(listCustomersQuery);
            SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows.Clear();
            foreach (var customer in customers.Items)
            {
                var configurationInfo = new DataGridViewRow();
                configurationInfo.CreateCells(SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView);
                configurationInfo.Cells[0].Value = customer.Id;
                configurationInfo.Cells[1].Value = customer.Name;
                configurationInfo.Cells[2].Value = customer.PhoneNumber;
                configurationInfo.Cells[3].Value = customer.Email;
                configurationInfo.Cells[4].Value = customer.Address;
                configurationInfo.Cells[5].Value = customer.Debts.Select(x => x.Debt).Sum();
                SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows.Add(configurationInfo);
            }
        }

        private void SaleBookTab_Pages_AddCustomerPage_SelectedCustomer_AddBooksButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SaleBookTab_Pages_AddCustomerPage_SelectedCustomerIdTextbox.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Lỗi chọn khách hàng");
                return;
            }
            SaleBookTab_Pages.SelectedIndex = 1;
            SaleBookTab_Pages_AddBooksPage.Enabled = true;
        }

        private void SaleBookTab_Pages_AddCustomerPage_Enter(object sender, EventArgs e)
        {
            SaleBookTab_Pages_AddBooksPage.Enabled = false;
        }

        private void SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.SelectedCells[0].RowIndex;
            var customerId = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() ?? string.Empty;
            var customerName = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString() ?? string.Empty;
            var customerPhoneNumber = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString() ?? string.Empty;
            var customerEmail = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows[selectedRowIndex].Cells[3].Value.ToString() ?? string.Empty;
            var customerAddress = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows[selectedRowIndex].Cells[4].Value.ToString() ?? string.Empty;
            var customerDebt = SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows[selectedRowIndex].Cells[5].Value.ToString() ?? string.Empty;

            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerIdTextbox.Text = customerId;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerNameTextbox.Text = customerName;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerPhoneNumerberTextbox.Text = customerPhoneNumber;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerEmailTextbox.Text = customerEmail;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerAddressTextbox.Text = customerAddress;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerDebtTextbox.Text = customerDebt;
        }

        private void SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var selectedRowIndex = SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.SelectedCells[0].RowIndex;
                var bookId = SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() ?? string.Empty;
                var bookName = SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString() ?? string.Empty;
                var bookPrice = SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString() ?? string.Empty;

                var bookInfo = new DataGridViewRow();

                bookInfo.CreateCells(SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView);
                bookInfo.Cells[0].Value = bookId;
                bookInfo.Cells[1].Value = bookName;
                bookInfo.Cells[2].Value = bookPrice;
                SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows.Add(bookInfo);

                var currentTotalPrice = decimal.Parse(SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalPriceTextbox.Text) + decimal.Parse(bookPrice);
                SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalPriceTextbox.Text = currentTotalPrice.ToString();
            }
        }

        private async void SaleBookTab_Pages_AddBooksPage_Enter(object sender, EventArgs e)
        {
            var listBooksQuery = new ListBooksQuery();
            var books = await _mediator.Send(listBooksQuery);
            SetSaleBookTab_Pages_AddBooksPage_SelectBookDataGridView(books.Items);

            SaleBookTab_Pages_AddBooksPage_SelectedCustomerNameTextbox.Text = SaleBookTab_Pages_AddCustomerPage_SelectedCustomerNameTextbox.Text;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerPhoneNumberTextbox.Text = SaleBookTab_Pages_AddCustomerPage_SelectedCustomerPhoneNumerberTextbox.Text;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerEmailTextbox.Text = SaleBookTab_Pages_AddCustomerPage_SelectedCustomerEmailTextbox.Text;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerAddressTextbox.Text = SaleBookTab_Pages_AddCustomerPage_SelectedCustomerAddressTextbox.Text;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalDebtTextbox.Text = SaleBookTab_Pages_AddCustomerPage_SelectedCustomerDebtTextbox.Text;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerReceivedMoneyTextbox.Text = "";
        }

        private void SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows.Count > 1)
            {
                var selectedRow = SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows[e.RowIndex];
                var isCellEmpty = selectedRow.Cells[0].Value;
                if (isCellEmpty == null)
                {
                    return;
                }
                var bookPrice = SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() ?? string.Empty;

                var currentTotalPrice = decimal.Parse(SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalPriceTextbox.Text) - decimal.Parse(bookPrice);
                SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalPriceTextbox.Text = currentTotalPrice.ToString();
                SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private async void SaleBookTab_Pages_AddBooksPage_SearchButton_Click(object sender, EventArgs e)
        {
            var bookCode = SaleBookTab_Pages_AddBooksPage_BookCodeTextbox.Text;
            var bookName = SaleBookTab_Pages_AddBooksPage_BookNameTextbox.Text;
            var listBooksQuery = new ListBooksQuery
            {
                BookCode = bookCode,
                BookName = bookName,
            };
            var books = await _mediator.Send(listBooksQuery);
            SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.Rows.Clear();
            SetSaleBookTab_Pages_AddBooksPage_SelectBookDataGridView(books.Items);
        }

        private void SetSaleBookTab_Pages_AddBooksPage_SelectBookDataGridView(IList<BookDto> books)
        {
            foreach (var book in books)
            {
                var bookInfo = new DataGridViewRow();
                bookInfo.CreateCells(SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView);
                bookInfo.Cells[0].Value = book.Id;
                bookInfo.Cells[1].Value = book.Name;
                bookInfo.Cells[2].Value = book.Price;
                SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.Rows.Add(bookInfo);
            }
        }

        private async void SaleBookTab_Pages_AddBooksPage_ExportReceiptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SaleBookTab_Pages_AddBooksPage_SelectedCustomerReceivedMoneyTextbox.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền đã nhận", "Lỗi nhập liệu");
                return;
            }
            var books = new List<BookInfo>();
            try
            {
                foreach (DataGridViewRow row in SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        var book = new BookInfo
                        {
                            Id = new Guid(row.Cells[0].Value.ToString()),
                            Name = row.Cells[1].Value.ToString(),
                        };
                        books.Add(book);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            var createReceiptCommand = new CreateReceiptCommand
            {
                Request = new CreateReceiptRequest
                {
                    StaffId = _userPermission.UserId,
                    CustomerId = new Guid(SaleBookTab_Pages_AddCustomerPage_SelectedCustomerIdTextbox.Text),
                    CustomerName = SaleBookTab_Pages_AddBooksPage_SelectedCustomerNameTextbox.Text,
                    CustomerPhoneNumber = SaleBookTab_Pages_AddBooksPage_SelectedCustomerPhoneNumberTextbox.Text,
                    CustomerEmail = SaleBookTab_Pages_AddBooksPage_SelectedCustomerEmailTextbox.Text,
                    CustomerAddress = SaleBookTab_Pages_AddBooksPage_SelectedCustomerAddressTextbox.Text,
                    TotalPrice = decimal.Parse(SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalPriceTextbox.Text),
                    ReceivedMoney = decimal.Parse(SaleBookTab_Pages_AddBooksPage_SelectedCustomerReceivedMoneyTextbox.Text),
                    Debt = decimal.Parse(SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalDebtTextbox.Text),
                    Books = books
                }
            };
            try
            {
                var result = await _mediator.Send(createReceiptCommand);
                if (result == CreateReceiptStatus.Success)
                {
                    ResetSaleBookTab();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private void ResetSaleBookTab()
        {
            SaleBookTab_Pages_AddBooksPage_BookCodeTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_BookNameTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectBookDataGridView.Rows.Clear();
            SaleBookTab_Pages_AddBooksPage_SelectedBookDataGridView.Rows.Clear();
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerIdTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerNameTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerPhoneNumberTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerEmailTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerAddressTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalPriceTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerReceivedMoneyTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddBooksPage_SelectedCustomerTotalDebtTextbox.Text = string.Empty;

            SaleBookTab_Pages_AddCustomerPage_CustomerIdSearchTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_CustomerNameSearchTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerIdTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerNameTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerPhoneNumerberTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerEmailTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerAddressTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_SelectedCustomerDebtTextbox.Text = string.Empty;
            SaleBookTab_Pages_AddCustomerPage_CustomersDataGridView.Rows.Clear();
        }

        private async void ReportPages_MainPages_InventoryReportPage_MainContainer_QueryGroup_SearchButton_Click(object sender, EventArgs e)
        {
            var inventoryReportQuery = new InventoryReportQuery
            {
                StartDate = ReportPages_MainPages_InventoryReportPage_MainContainer_QueryGroup_StartDateDateTimePicker.Value,
                EndDate = ReportPages_MainPages_InventoryReportPage_MainContainer_QueryGroup_EndDateDateTimePicker.Value
            };

            var result = await _mediator.Send(inventoryReportQuery);
        }
    }
}