namespace BookStoreManagementSystem
{
    partial class BookStoreUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainNav = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.HomeTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.HomeTab_LoginContainer_LoginButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.HomeTab_LoginContainer_PasswordTextBook = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.HomeTab_LoginContainer_UserNameTextBox = new System.Windows.Forms.TextBox();
            this.ImportBookTab = new System.Windows.Forms.TabPage();
            this.ImportBookMenu_MainContainer = new System.Windows.Forms.SplitContainer();
            this.ImportBookMenu_QueryBook_SubmitButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.ImportBookMenu_QueryBook_ImportQuantityNum = new System.Windows.Forms.NumericUpDown();
            this.ImportBookMenu_QueryBook_BookNameComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ImportBookMenu_QueryBook_BookStore_ComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ImportBookMenu_BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryBookTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.QueryBookMenu_BookInfo_Tab = new System.Windows.Forms.TabPage();
            this.QueryBookMenu_QueryBookTab = new System.Windows.Forms.SplitContainer();
            this.QueryBook_BookType_ComboBox = new System.Windows.Forms.ComboBox();
            this.QueryBook_Price_ComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QueryBook_AuthorName_TextBox = new System.Windows.Forms.TextBox();
            this.QueryBook_BookCode_TextBox = new System.Windows.Forms.TextBox();
            this.QueryBook_BookName_TextBox = new System.Windows.Forms.TextBox();
            this.QueryBookMenu_BookInfo_SearchBook_Button = new System.Windows.Forms.Button();
            this.bookQuery_ListBooks = new System.Windows.Forms.DataGridView();
            this.BookQueryGrib_BookNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_AuthorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryBookMenu_AddBook_Tab = new System.Windows.Forms.TabPage();
            this.QueryBookMenu_AddBookTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox = new System.Windows.Forms.TextBox();
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleBookTab = new System.Windows.Forms.TabPage();
            this.SellBookTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.CustomerInfoTab = new System.Windows.Forms.TabPage();
            this.CustomerMenu_MainContainer = new System.Windows.Forms.SplitContainer();
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer = new System.Windows.Forms.SplitContainer();
            this.CustomerMenu_QueryCustomer_Search_Button = new System.Windows.Forms.Button();
            this.CustomerMenu_QueryCustomer_FullName_Textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CustomerMenu_QueryCustomer_Id_Textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerMenu_QueryCustomer_CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffInfoTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.StaffInfo_SearchStaff_Search_Button = new System.Windows.Forms.Button();
            this.StaffInfo_SearchStaff_Position_Textbox = new System.Windows.Forms.TextBox();
            this.StaffInfo_SearchStaff_Age_Textbox = new System.Windows.Forms.TextBox();
            this.StaffInfo_SearchStaff_Name_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffInfo_SearchStaff_StaffInfo_GridTable = new System.Windows.Forms.DataGridView();
            this.StaffInfo_SearchStaff_Name_GridTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffInfo_SearchStaff_Address_GridTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffInfo_SearchStaff_Age_GridTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffInfo_SearchStaff_Position_GridTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffInfo_SearchStaff_PhoneNumber_GridTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigurationTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.ConfigurationTab_BookStoreConfigurationTab = new System.Windows.Forms.TabPage();
            this.ConfigurationTab_CustomerConfigurationTab = new System.Windows.Forms.TabPage();
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.label23 = new System.Windows.Forms.Label();
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView = new System.Windows.Forms.DataGridView();
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.MainNav.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTab_MainContainer)).BeginInit();
            this.HomeTab_MainContainer.Panel1.SuspendLayout();
            this.HomeTab_MainContainer.SuspendLayout();
            this.ImportBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBookMenu_MainContainer)).BeginInit();
            this.ImportBookMenu_MainContainer.Panel1.SuspendLayout();
            this.ImportBookMenu_MainContainer.Panel2.SuspendLayout();
            this.ImportBookMenu_MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBookMenu_QueryBook_ImportQuantityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBookMenu_BooksDataGridView)).BeginInit();
            this.QueryBookTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.QueryBookMenu_BookInfo_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBookMenu_QueryBookTab)).BeginInit();
            this.QueryBookMenu_QueryBookTab.Panel1.SuspendLayout();
            this.QueryBookMenu_QueryBookTab.Panel2.SuspendLayout();
            this.QueryBookMenu_QueryBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookQuery_ListBooks)).BeginInit();
            this.QueryBookMenu_AddBook_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBookMenu_AddBookTab_MainContainer)).BeginInit();
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.SuspendLayout();
            this.QueryBookMenu_AddBookTab_MainContainer.Panel2.SuspendLayout();
            this.QueryBookMenu_AddBookTab_MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView)).BeginInit();
            this.SaleBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellBookTab_MainContainer)).BeginInit();
            this.SellBookTab_MainContainer.SuspendLayout();
            this.CustomerInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMenu_MainContainer)).BeginInit();
            this.CustomerMenu_MainContainer.Panel1.SuspendLayout();
            this.CustomerMenu_MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMenu_MainContainer_QueryCustomerSubContainer)).BeginInit();
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.SuspendLayout();
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel2.SuspendLayout();
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMenu_QueryCustomer_CustomerDataGridView)).BeginInit();
            this.StaffInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffInfo_SearchStaff_StaffInfo_GridTable)).BeginInit();
            this.ConfigurationTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.ConfigurationTab_BookStoreConfigurationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationTab_BookStoreConfigurationTab_MainContainer)).BeginInit();
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.SuspendLayout();
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel2.SuspendLayout();
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // MainNav
            // 
            this.MainNav.Controls.Add(this.HomeTab);
            this.MainNav.Controls.Add(this.ImportBookTab);
            this.MainNav.Controls.Add(this.QueryBookTab);
            this.MainNav.Controls.Add(this.SaleBookTab);
            this.MainNav.Controls.Add(this.CustomerInfoTab);
            this.MainNav.Controls.Add(this.StaffInfoTab);
            this.MainNav.Controls.Add(this.ConfigurationTab);
            this.MainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainNav.Location = new System.Drawing.Point(0, 0);
            this.MainNav.Name = "MainNav";
            this.MainNav.SelectedIndex = 0;
            this.MainNav.Size = new System.Drawing.Size(984, 561);
            this.MainNav.TabIndex = 1;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.HomeTab_MainContainer);
            this.HomeTab.Location = new System.Drawing.Point(4, 24);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(976, 533);
            this.HomeTab.TabIndex = 5;
            this.HomeTab.Text = "HOME";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // HomeTab_MainContainer
            // 
            this.HomeTab_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTab_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.HomeTab_MainContainer.Name = "HomeTab_MainContainer";
            // 
            // HomeTab_MainContainer.Panel1
            // 
            this.HomeTab_MainContainer.Panel1.Controls.Add(this.HomeTab_LoginContainer_LoginButton);
            this.HomeTab_MainContainer.Panel1.Controls.Add(this.label22);
            this.HomeTab_MainContainer.Panel1.Controls.Add(this.HomeTab_LoginContainer_PasswordTextBook);
            this.HomeTab_MainContainer.Panel1.Controls.Add(this.label21);
            this.HomeTab_MainContainer.Panel1.Controls.Add(this.HomeTab_LoginContainer_UserNameTextBox);
            this.HomeTab_MainContainer.Size = new System.Drawing.Size(970, 527);
            this.HomeTab_MainContainer.SplitterDistance = 323;
            this.HomeTab_MainContainer.TabIndex = 0;
            // 
            // HomeTab_LoginContainer_LoginButton
            // 
            this.HomeTab_LoginContainer_LoginButton.Location = new System.Drawing.Point(22, 170);
            this.HomeTab_LoginContainer_LoginButton.Name = "HomeTab_LoginContainer_LoginButton";
            this.HomeTab_LoginContainer_LoginButton.Size = new System.Drawing.Size(75, 23);
            this.HomeTab_LoginContainer_LoginButton.TabIndex = 7;
            this.HomeTab_LoginContainer_LoginButton.Text = "Đăng nhập";
            this.HomeTab_LoginContainer_LoginButton.UseVisualStyleBackColor = true;
            this.HomeTab_LoginContainer_LoginButton.Click += new System.EventHandler(this.HomeTab_LoginContainer_LoginButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 15);
            this.label22.TabIndex = 6;
            this.label22.Text = "Mật khẩu";
            // 
            // HomeTab_LoginContainer_PasswordTextBook
            // 
            this.HomeTab_LoginContainer_PasswordTextBook.Location = new System.Drawing.Point(22, 120);
            this.HomeTab_LoginContainer_PasswordTextBook.Name = "HomeTab_LoginContainer_PasswordTextBook";
            this.HomeTab_LoginContainer_PasswordTextBook.Size = new System.Drawing.Size(195, 23);
            this.HomeTab_LoginContainer_PasswordTextBook.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 15);
            this.label21.TabIndex = 4;
            this.label21.Text = "Tên đăng nhập";
            // 
            // HomeTab_LoginContainer_UserNameTextBox
            // 
            this.HomeTab_LoginContainer_UserNameTextBox.Location = new System.Drawing.Point(22, 61);
            this.HomeTab_LoginContainer_UserNameTextBox.Name = "HomeTab_LoginContainer_UserNameTextBox";
            this.HomeTab_LoginContainer_UserNameTextBox.Size = new System.Drawing.Size(195, 23);
            this.HomeTab_LoginContainer_UserNameTextBox.TabIndex = 3;
            // 
            // ImportBookTab
            // 
            this.ImportBookTab.Controls.Add(this.ImportBookMenu_MainContainer);
            this.ImportBookTab.Location = new System.Drawing.Point(4, 24);
            this.ImportBookTab.Name = "ImportBookTab";
            this.ImportBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportBookTab.Size = new System.Drawing.Size(976, 533);
            this.ImportBookTab.TabIndex = 0;
            this.ImportBookTab.Text = "Nhập sách";
            this.ImportBookTab.UseVisualStyleBackColor = true;
            this.ImportBookTab.Enter += new System.EventHandler(this.ImportBookTab_Enter);
            // 
            // ImportBookMenu_MainContainer
            // 
            this.ImportBookMenu_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBookMenu_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.ImportBookMenu_MainContainer.Name = "ImportBookMenu_MainContainer";
            this.ImportBookMenu_MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ImportBookMenu_MainContainer.Panel1
            // 
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.ImportBookMenu_QueryBook_SubmitButton);
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.label20);
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.ImportBookMenu_QueryBook_ImportQuantityNum);
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.ImportBookMenu_QueryBook_BookNameComboBox);
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.label19);
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.ImportBookMenu_QueryBook_BookStore_ComboBox);
            this.ImportBookMenu_MainContainer.Panel1.Controls.Add(this.label14);
            // 
            // ImportBookMenu_MainContainer.Panel2
            // 
            this.ImportBookMenu_MainContainer.Panel2.Controls.Add(this.ImportBookMenu_BooksDataGridView);
            this.ImportBookMenu_MainContainer.Size = new System.Drawing.Size(970, 527);
            this.ImportBookMenu_MainContainer.SplitterDistance = 150;
            this.ImportBookMenu_MainContainer.TabIndex = 0;
            // 
            // ImportBookMenu_QueryBook_SubmitButton
            // 
            this.ImportBookMenu_QueryBook_SubmitButton.Location = new System.Drawing.Point(434, 96);
            this.ImportBookMenu_QueryBook_SubmitButton.Name = "ImportBookMenu_QueryBook_SubmitButton";
            this.ImportBookMenu_QueryBook_SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.ImportBookMenu_QueryBook_SubmitButton.TabIndex = 11;
            this.ImportBookMenu_QueryBook_SubmitButton.Text = "Xác nhận";
            this.ImportBookMenu_QueryBook_SubmitButton.UseVisualStyleBackColor = true;
            this.ImportBookMenu_QueryBook_SubmitButton.Click += new System.EventHandler(this.ImportBookMenu_QueryBook_SubmitButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(249, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "Số lượng";
            // 
            // ImportBookMenu_QueryBook_ImportQuantityNum
            // 
            this.ImportBookMenu_QueryBook_ImportQuantityNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ImportBookMenu_QueryBook_ImportQuantityNum.Location = new System.Drawing.Point(249, 96);
            this.ImportBookMenu_QueryBook_ImportQuantityNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImportBookMenu_QueryBook_ImportQuantityNum.Name = "ImportBookMenu_QueryBook_ImportQuantityNum";
            this.ImportBookMenu_QueryBook_ImportQuantityNum.Size = new System.Drawing.Size(120, 23);
            this.ImportBookMenu_QueryBook_ImportQuantityNum.TabIndex = 9;
            this.ImportBookMenu_QueryBook_ImportQuantityNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ImportBookMenu_QueryBook_BookNameComboBox
            // 
            this.ImportBookMenu_QueryBook_BookNameComboBox.FormattingEnabled = true;
            this.ImportBookMenu_QueryBook_BookNameComboBox.Location = new System.Drawing.Point(18, 96);
            this.ImportBookMenu_QueryBook_BookNameComboBox.Name = "ImportBookMenu_QueryBook_BookNameComboBox";
            this.ImportBookMenu_QueryBook_BookNameComboBox.Size = new System.Drawing.Size(174, 23);
            this.ImportBookMenu_QueryBook_BookNameComboBox.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "Sách";
            // 
            // ImportBookMenu_QueryBook_BookStore_ComboBox
            // 
            this.ImportBookMenu_QueryBook_BookStore_ComboBox.FormattingEnabled = true;
            this.ImportBookMenu_QueryBook_BookStore_ComboBox.Location = new System.Drawing.Point(18, 37);
            this.ImportBookMenu_QueryBook_BookStore_ComboBox.Name = "ImportBookMenu_QueryBook_BookStore_ComboBox";
            this.ImportBookMenu_QueryBook_BookStore_ComboBox.Size = new System.Drawing.Size(174, 23);
            this.ImportBookMenu_QueryBook_BookStore_ComboBox.TabIndex = 5;
            this.ImportBookMenu_QueryBook_BookStore_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ImportBookMenu_QueryBook_BookStore_ComboBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nhà sách";
            // 
            // ImportBookMenu_BooksDataGridView
            // 
            this.ImportBookMenu_BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportBookMenu_BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BookCode,
            this.BookType,
            this.Available,
            this.Action});
            this.ImportBookMenu_BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBookMenu_BooksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ImportBookMenu_BooksDataGridView.Name = "ImportBookMenu_BooksDataGridView";
            this.ImportBookMenu_BooksDataGridView.RowTemplate.Height = 25;
            this.ImportBookMenu_BooksDataGridView.Size = new System.Drawing.Size(970, 373);
            this.ImportBookMenu_BooksDataGridView.TabIndex = 2;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.HeaderText = "Tên sách";
            this.BookName.Name = "BookName";
            // 
            // BookCode
            // 
            this.BookCode.HeaderText = "Mã sách";
            this.BookCode.Name = "BookCode";
            this.BookCode.Width = 150;
            // 
            // BookType
            // 
            this.BookType.HeaderText = "Loại sách";
            this.BookType.Name = "BookType";
            this.BookType.Width = 150;
            // 
            // Available
            // 
            this.Available.HeaderText = "Số lượng đã nhận";
            this.Available.Name = "Available";
            this.Available.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "Thao tác";
            this.Action.Name = "Action";
            this.Action.Width = 150;
            // 
            // QueryBookTab
            // 
            this.QueryBookTab.Controls.Add(this.tabControl1);
            this.QueryBookTab.Location = new System.Drawing.Point(4, 24);
            this.QueryBookTab.Name = "QueryBookTab";
            this.QueryBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.QueryBookTab.Size = new System.Drawing.Size(976, 533);
            this.QueryBookTab.TabIndex = 1;
            this.QueryBookTab.Text = "Tra cứu sách";
            this.QueryBookTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.QueryBookMenu_BookInfo_Tab);
            this.tabControl1.Controls.Add(this.QueryBookMenu_AddBook_Tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // QueryBookMenu_BookInfo_Tab
            // 
            this.QueryBookMenu_BookInfo_Tab.Controls.Add(this.QueryBookMenu_QueryBookTab);
            this.QueryBookMenu_BookInfo_Tab.Location = new System.Drawing.Point(4, 24);
            this.QueryBookMenu_BookInfo_Tab.Name = "QueryBookMenu_BookInfo_Tab";
            this.QueryBookMenu_BookInfo_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.QueryBookMenu_BookInfo_Tab.Size = new System.Drawing.Size(962, 499);
            this.QueryBookMenu_BookInfo_Tab.TabIndex = 0;
            this.QueryBookMenu_BookInfo_Tab.Text = "Thông tin sách";
            this.QueryBookMenu_BookInfo_Tab.UseVisualStyleBackColor = true;
            // 
            // QueryBookMenu_QueryBookTab
            // 
            this.QueryBookMenu_QueryBookTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryBookMenu_QueryBookTab.Location = new System.Drawing.Point(3, 3);
            this.QueryBookMenu_QueryBookTab.Name = "QueryBookMenu_QueryBookTab";
            this.QueryBookMenu_QueryBookTab.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // QueryBookMenu_QueryBookTab.Panel1
            // 
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.QueryBook_BookType_ComboBox);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.QueryBook_Price_ComboBox);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.label11);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.label7);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.label9);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.label8);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.label10);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.label2);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.QueryBook_AuthorName_TextBox);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.QueryBook_BookCode_TextBox);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.QueryBook_BookName_TextBox);
            this.QueryBookMenu_QueryBookTab.Panel1.Controls.Add(this.QueryBookMenu_BookInfo_SearchBook_Button);
            // 
            // QueryBookMenu_QueryBookTab.Panel2
            // 
            this.QueryBookMenu_QueryBookTab.Panel2.Controls.Add(this.bookQuery_ListBooks);
            this.QueryBookMenu_QueryBookTab.Size = new System.Drawing.Size(956, 493);
            this.QueryBookMenu_QueryBookTab.SplitterDistance = 140;
            this.QueryBookMenu_QueryBookTab.TabIndex = 4;
            // 
            // QueryBook_BookType_ComboBox
            // 
            this.QueryBook_BookType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueryBook_BookType_ComboBox.FormattingEnabled = true;
            this.QueryBook_BookType_ComboBox.Items.AddRange(new object[] {
            "Dưới 50.000 VNĐ",
            "50.000-100.000 VNĐ",
            "100.000-500.000 VNĐ",
            "500.000-1.000.000 VNĐ",
            "Trên 1.000.000 VNĐ"});
            this.QueryBook_BookType_ComboBox.Location = new System.Drawing.Point(212, 94);
            this.QueryBook_BookType_ComboBox.Name = "QueryBook_BookType_ComboBox";
            this.QueryBook_BookType_ComboBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBook_BookType_ComboBox.TabIndex = 3;
            // 
            // QueryBook_Price_ComboBox
            // 
            this.QueryBook_Price_ComboBox.FormattingEnabled = true;
            this.QueryBook_Price_ComboBox.Location = new System.Drawing.Point(413, 39);
            this.QueryBook_Price_ComboBox.Name = "QueryBook_Price_ComboBox";
            this.QueryBook_Price_ComboBox.Size = new System.Drawing.Size(174, 23);
            this.QueryBook_Price_ComboBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Loại sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tìm kiếm sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên tác giả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // QueryBook_AuthorName_TextBox
            // 
            this.QueryBook_AuthorName_TextBox.Location = new System.Drawing.Point(212, 38);
            this.QueryBook_AuthorName_TextBox.Name = "QueryBook_AuthorName_TextBox";
            this.QueryBook_AuthorName_TextBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBook_AuthorName_TextBox.TabIndex = 0;
            // 
            // QueryBook_BookCode_TextBox
            // 
            this.QueryBook_BookCode_TextBox.Location = new System.Drawing.Point(11, 94);
            this.QueryBook_BookCode_TextBox.Name = "QueryBook_BookCode_TextBox";
            this.QueryBook_BookCode_TextBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBook_BookCode_TextBox.TabIndex = 0;
            // 
            // QueryBook_BookName_TextBox
            // 
            this.QueryBook_BookName_TextBox.Location = new System.Drawing.Point(11, 38);
            this.QueryBook_BookName_TextBox.Name = "QueryBook_BookName_TextBox";
            this.QueryBook_BookName_TextBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBook_BookName_TextBox.TabIndex = 0;
            // 
            // QueryBookMenu_BookInfo_SearchBook_Button
            // 
            this.QueryBookMenu_BookInfo_SearchBook_Button.Location = new System.Drawing.Point(413, 94);
            this.QueryBookMenu_BookInfo_SearchBook_Button.Name = "QueryBookMenu_BookInfo_SearchBook_Button";
            this.QueryBookMenu_BookInfo_SearchBook_Button.Size = new System.Drawing.Size(75, 23);
            this.QueryBookMenu_BookInfo_SearchBook_Button.TabIndex = 1;
            this.QueryBookMenu_BookInfo_SearchBook_Button.Text = "Tìm kiếm";
            this.QueryBookMenu_BookInfo_SearchBook_Button.UseVisualStyleBackColor = true;
            this.QueryBookMenu_BookInfo_SearchBook_Button.Click += new System.EventHandler(this.QueryBookMenu_BookInfo_SearchBook_Button_Click);
            // 
            // bookQuery_ListBooks
            // 
            this.bookQuery_ListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookQuery_ListBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookQueryGrib_BookNameColumn,
            this.BookQueryGrib_BookCodeColumn,
            this.BookQueryGrib_BookTypeColumn,
            this.BookQueryGrib_AuthorNameColumn,
            this.BookQueryGrib_BookPriceColumn});
            this.bookQuery_ListBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookQuery_ListBooks.Location = new System.Drawing.Point(0, 0);
            this.bookQuery_ListBooks.Name = "bookQuery_ListBooks";
            this.bookQuery_ListBooks.RowTemplate.Height = 25;
            this.bookQuery_ListBooks.Size = new System.Drawing.Size(956, 349);
            this.bookQuery_ListBooks.TabIndex = 2;
            // 
            // BookQueryGrib_BookNameColumn
            // 
            this.BookQueryGrib_BookNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookQueryGrib_BookNameColumn.HeaderText = "Tên sách";
            this.BookQueryGrib_BookNameColumn.Name = "BookQueryGrib_BookNameColumn";
            // 
            // BookQueryGrib_BookCodeColumn
            // 
            this.BookQueryGrib_BookCodeColumn.HeaderText = "Mã sách";
            this.BookQueryGrib_BookCodeColumn.Name = "BookQueryGrib_BookCodeColumn";
            this.BookQueryGrib_BookCodeColumn.Width = 150;
            // 
            // BookQueryGrib_BookTypeColumn
            // 
            this.BookQueryGrib_BookTypeColumn.HeaderText = "Loại sách";
            this.BookQueryGrib_BookTypeColumn.Name = "BookQueryGrib_BookTypeColumn";
            this.BookQueryGrib_BookTypeColumn.Width = 150;
            // 
            // BookQueryGrib_AuthorNameColumn
            // 
            this.BookQueryGrib_AuthorNameColumn.HeaderText = "Tên tác giả";
            this.BookQueryGrib_AuthorNameColumn.Name = "BookQueryGrib_AuthorNameColumn";
            this.BookQueryGrib_AuthorNameColumn.Width = 150;
            // 
            // BookQueryGrib_BookPriceColumn
            // 
            this.BookQueryGrib_BookPriceColumn.HeaderText = "Giá sách";
            this.BookQueryGrib_BookPriceColumn.Name = "BookQueryGrib_BookPriceColumn";
            this.BookQueryGrib_BookPriceColumn.Width = 150;
            // 
            // QueryBookMenu_AddBook_Tab
            // 
            this.QueryBookMenu_AddBook_Tab.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer);
            this.QueryBookMenu_AddBook_Tab.Location = new System.Drawing.Point(4, 24);
            this.QueryBookMenu_AddBook_Tab.Name = "QueryBookMenu_AddBook_Tab";
            this.QueryBookMenu_AddBook_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.QueryBookMenu_AddBook_Tab.Size = new System.Drawing.Size(962, 499);
            this.QueryBookMenu_AddBook_Tab.TabIndex = 1;
            this.QueryBookMenu_AddBook_Tab.Text = "Thêm mới sách";
            this.QueryBookMenu_AddBook_Tab.UseVisualStyleBackColor = true;
            // 
            // QueryBookMenu_AddBookTab_MainContainer
            // 
            this.QueryBookMenu_AddBookTab_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryBookMenu_AddBookTab_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.QueryBookMenu_AddBookTab_MainContainer.Name = "QueryBookMenu_AddBookTab_MainContainer";
            // 
            // QueryBookMenu_AddBookTab_MainContainer.Panel1
            // 
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.label18);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.label17);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.label16);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.Controls.Add(this.label15);
            // 
            // QueryBookMenu_AddBookTab_MainContainer.Panel2
            // 
            this.QueryBookMenu_AddBookTab_MainContainer.Panel2.Controls.Add(this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView);
            this.QueryBookMenu_AddBookTab_MainContainer.Size = new System.Drawing.Size(956, 493);
            this.QueryBookMenu_AddBookTab_MainContainer.SplitterDistance = 318;
            this.QueryBookMenu_AddBookTab_MainContainer.TabIndex = 0;
            // 
            // QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.Location = new System.Drawing.Point(25, 287);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.Name = "QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton";
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.Size = new System.Drawing.Size(75, 23);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.TabIndex = 12;
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.Text = "Thêm";
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.UseVisualStyleBackColor = true;
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton.Click += new System.EventHandler(this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "Giá";
            // 
            // QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook.Location = new System.Drawing.Point(25, 240);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook.Name = "QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook";
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook.Size = new System.Drawing.Size(195, 23);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Tên sách";
            // 
            // QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox.Location = new System.Drawing.Point(25, 57);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox.Name = "QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox";
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox.TabIndex = 8;
            // 
            // QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.FormattingEnabled = true;
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.Location = new System.Drawing.Point(25, 182);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.Name = "QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox";
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Tác giả";
            // 
            // QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.FormattingEnabled = true;
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.Location = new System.Drawing.Point(25, 118);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.Name = "QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox";
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.Size = new System.Drawing.Size(195, 23);
            this.QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Thể loại";
            // 
            // QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn,
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn,
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName});
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.Name = "QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView";
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.RowTemplate.Height = 25;
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.Size = new System.Drawing.Size(634, 493);
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView.TabIndex = 0;
            // 
            // QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn.HeaderText = "Id";
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn.Name = "QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn";
            // 
            // QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn.HeaderText = "Tên sách";
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn.Name = "QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn";
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn.Width = 200;
            // 
            // QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName
            // 
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName.HeaderText = "Tên tác giả";
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName.Name = "QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName";
            this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName.Width = 200;
            // 
            // SaleBookTab
            // 
            this.SaleBookTab.Controls.Add(this.SellBookTab_MainContainer);
            this.SaleBookTab.Location = new System.Drawing.Point(4, 24);
            this.SaleBookTab.Name = "SaleBookTab";
            this.SaleBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.SaleBookTab.Size = new System.Drawing.Size(976, 533);
            this.SaleBookTab.TabIndex = 2;
            this.SaleBookTab.Text = "Bán sách";
            this.SaleBookTab.UseVisualStyleBackColor = true;
            // 
            // SellBookTab_MainContainer
            // 
            this.SellBookTab_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellBookTab_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.SellBookTab_MainContainer.Name = "SellBookTab_MainContainer";
            this.SellBookTab_MainContainer.Size = new System.Drawing.Size(970, 527);
            this.SellBookTab_MainContainer.SplitterDistance = 323;
            this.SellBookTab_MainContainer.TabIndex = 0;
            // 
            // CustomerInfoTab
            // 
            this.CustomerInfoTab.Controls.Add(this.CustomerMenu_MainContainer);
            this.CustomerInfoTab.Location = new System.Drawing.Point(4, 24);
            this.CustomerInfoTab.Name = "CustomerInfoTab";
            this.CustomerInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerInfoTab.Size = new System.Drawing.Size(976, 533);
            this.CustomerInfoTab.TabIndex = 3;
            this.CustomerInfoTab.Text = "Khách hàng";
            this.CustomerInfoTab.UseVisualStyleBackColor = true;
            // 
            // CustomerMenu_MainContainer
            // 
            this.CustomerMenu_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerMenu_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.CustomerMenu_MainContainer.Name = "CustomerMenu_MainContainer";
            // 
            // CustomerMenu_MainContainer.Panel1
            // 
            this.CustomerMenu_MainContainer.Panel1.Controls.Add(this.CustomerMenu_MainContainer_QueryCustomerSubContainer);
            this.CustomerMenu_MainContainer.Size = new System.Drawing.Size(970, 527);
            this.CustomerMenu_MainContainer.SplitterDistance = 600;
            this.CustomerMenu_MainContainer.TabIndex = 0;
            // 
            // CustomerMenu_MainContainer_QueryCustomerSubContainer
            // 
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Location = new System.Drawing.Point(0, 0);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Name = "CustomerMenu_MainContainer_QueryCustomerSubContainer";
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1
            // 
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.Controls.Add(this.CustomerMenu_QueryCustomer_Search_Button);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.Controls.Add(this.CustomerMenu_QueryCustomer_FullName_Textbox);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.Controls.Add(this.label13);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.Controls.Add(this.CustomerMenu_QueryCustomer_Id_Textbox);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.Controls.Add(this.label12);
            // 
            // CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel2
            // 
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel2.Controls.Add(this.CustomerMenu_QueryCustomer_CustomerDataGridView);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Size = new System.Drawing.Size(600, 527);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.SplitterDistance = 100;
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.TabIndex = 0;
            // 
            // CustomerMenu_QueryCustomer_Search_Button
            // 
            this.CustomerMenu_QueryCustomer_Search_Button.Location = new System.Drawing.Point(366, 45);
            this.CustomerMenu_QueryCustomer_Search_Button.Name = "CustomerMenu_QueryCustomer_Search_Button";
            this.CustomerMenu_QueryCustomer_Search_Button.Size = new System.Drawing.Size(75, 23);
            this.CustomerMenu_QueryCustomer_Search_Button.TabIndex = 4;
            this.CustomerMenu_QueryCustomer_Search_Button.Text = "Tìm kiếm";
            this.CustomerMenu_QueryCustomer_Search_Button.UseVisualStyleBackColor = true;
            this.CustomerMenu_QueryCustomer_Search_Button.Click += new System.EventHandler(this.CustomerMenu_QueryCustomer_Search_Button_Click);
            // 
            // CustomerMenu_QueryCustomer_FullName_Textbox
            // 
            this.CustomerMenu_QueryCustomer_FullName_Textbox.Location = new System.Drawing.Point(199, 45);
            this.CustomerMenu_QueryCustomer_FullName_Textbox.Name = "CustomerMenu_QueryCustomer_FullName_Textbox";
            this.CustomerMenu_QueryCustomer_FullName_Textbox.Size = new System.Drawing.Size(161, 23);
            this.CustomerMenu_QueryCustomer_FullName_Textbox.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Họ tên";
            // 
            // CustomerMenu_QueryCustomer_Id_Textbox
            // 
            this.CustomerMenu_QueryCustomer_Id_Textbox.Location = new System.Drawing.Point(32, 45);
            this.CustomerMenu_QueryCustomer_Id_Textbox.Name = "CustomerMenu_QueryCustomer_Id_Textbox";
            this.CustomerMenu_QueryCustomer_Id_Textbox.Size = new System.Drawing.Size(161, 23);
            this.CustomerMenu_QueryCustomer_Id_Textbox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Id";
            // 
            // CustomerMenu_QueryCustomer_CustomerDataGridView
            // 
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column,
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column,
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column,
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column});
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.Name = "CustomerMenu_QueryCustomer_CustomerDataGridView";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.RowTemplate.Height = 25;
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.Size = new System.Drawing.Size(600, 423);
            this.CustomerMenu_QueryCustomer_CustomerDataGridView.TabIndex = 0;
            // 
            // CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column
            // 
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column.HeaderText = "Id";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column.Name = "CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column";
            // 
            // CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column
            // 
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column.HeaderText = "Họ tên";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column.Name = "CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column.Width = 150;
            // 
            // CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column
            // 
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column.HeaderText = "Địa chỉ";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column.Name = "CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column.Width = 150;
            // 
            // CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column
            // 
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column.HeaderText = "Số điện thoại";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column.Name = "CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column";
            this.CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column.Width = 150;
            // 
            // StaffInfoTab
            // 
            this.StaffInfoTab.Controls.Add(this.splitContainer1);
            this.StaffInfoTab.Location = new System.Drawing.Point(4, 24);
            this.StaffInfoTab.Name = "StaffInfoTab";
            this.StaffInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffInfoTab.Size = new System.Drawing.Size(976, 533);
            this.StaffInfoTab.TabIndex = 4;
            this.StaffInfoTab.Text = "Nhân viên";
            this.StaffInfoTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(970, 527);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.StaffInfo_SearchStaff_Search_Button);
            this.splitContainer2.Panel1.Controls.Add(this.StaffInfo_SearchStaff_Position_Textbox);
            this.splitContainer2.Panel1.Controls.Add(this.StaffInfo_SearchStaff_Age_Textbox);
            this.splitContainer2.Panel1.Controls.Add(this.StaffInfo_SearchStaff_Name_Textbox);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.StaffInfo_SearchStaff_StaffInfo_GridTable);
            this.splitContainer2.Size = new System.Drawing.Size(600, 527);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 0;
            // 
            // StaffInfo_SearchStaff_Search_Button
            // 
            this.StaffInfo_SearchStaff_Search_Button.Location = new System.Drawing.Point(351, 42);
            this.StaffInfo_SearchStaff_Search_Button.Name = "StaffInfo_SearchStaff_Search_Button";
            this.StaffInfo_SearchStaff_Search_Button.Size = new System.Drawing.Size(75, 23);
            this.StaffInfo_SearchStaff_Search_Button.TabIndex = 1;
            this.StaffInfo_SearchStaff_Search_Button.Text = "Tìm kiếm";
            this.StaffInfo_SearchStaff_Search_Button.UseVisualStyleBackColor = true;
            this.StaffInfo_SearchStaff_Search_Button.Click += new System.EventHandler(this.StaffInfo_SearchStaff_Search_Button_Click);
            // 
            // StaffInfo_SearchStaff_Position_Textbox
            // 
            this.StaffInfo_SearchStaff_Position_Textbox.Location = new System.Drawing.Point(245, 42);
            this.StaffInfo_SearchStaff_Position_Textbox.Name = "StaffInfo_SearchStaff_Position_Textbox";
            this.StaffInfo_SearchStaff_Position_Textbox.Size = new System.Drawing.Size(100, 23);
            this.StaffInfo_SearchStaff_Position_Textbox.TabIndex = 1;
            // 
            // StaffInfo_SearchStaff_Age_Textbox
            // 
            this.StaffInfo_SearchStaff_Age_Textbox.Location = new System.Drawing.Point(139, 42);
            this.StaffInfo_SearchStaff_Age_Textbox.Name = "StaffInfo_SearchStaff_Age_Textbox";
            this.StaffInfo_SearchStaff_Age_Textbox.Size = new System.Drawing.Size(100, 23);
            this.StaffInfo_SearchStaff_Age_Textbox.TabIndex = 1;
            // 
            // StaffInfo_SearchStaff_Name_Textbox
            // 
            this.StaffInfo_SearchStaff_Name_Textbox.Location = new System.Drawing.Point(33, 42);
            this.StaffInfo_SearchStaff_Name_Textbox.Name = "StaffInfo_SearchStaff_Name_Textbox";
            this.StaffInfo_SearchStaff_Name_Textbox.Size = new System.Drawing.Size(100, 23);
            this.StaffInfo_SearchStaff_Name_Textbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm thông tin nhân viên";
            // 
            // StaffInfo_SearchStaff_StaffInfo_GridTable
            // 
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffInfo_SearchStaff_Name_GridTable,
            this.StaffInfo_SearchStaff_Address_GridTable,
            this.StaffInfo_SearchStaff_Age_GridTable,
            this.StaffInfo_SearchStaff_Position_GridTable,
            this.StaffInfo_SearchStaff_PhoneNumber_GridTable});
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.Location = new System.Drawing.Point(0, 0);
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.Name = "StaffInfo_SearchStaff_StaffInfo_GridTable";
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.RowTemplate.Height = 25;
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.Size = new System.Drawing.Size(600, 423);
            this.StaffInfo_SearchStaff_StaffInfo_GridTable.TabIndex = 1;
            // 
            // StaffInfo_SearchStaff_Name_GridTable
            // 
            this.StaffInfo_SearchStaff_Name_GridTable.HeaderText = "Họ tên";
            this.StaffInfo_SearchStaff_Name_GridTable.Name = "StaffInfo_SearchStaff_Name_GridTable";
            // 
            // StaffInfo_SearchStaff_Address_GridTable
            // 
            this.StaffInfo_SearchStaff_Address_GridTable.HeaderText = "Địa chỉ";
            this.StaffInfo_SearchStaff_Address_GridTable.Name = "StaffInfo_SearchStaff_Address_GridTable";
            // 
            // StaffInfo_SearchStaff_Age_GridTable
            // 
            this.StaffInfo_SearchStaff_Age_GridTable.HeaderText = "Tuổi";
            this.StaffInfo_SearchStaff_Age_GridTable.Name = "StaffInfo_SearchStaff_Age_GridTable";
            // 
            // StaffInfo_SearchStaff_Position_GridTable
            // 
            this.StaffInfo_SearchStaff_Position_GridTable.HeaderText = "Chức vụ";
            this.StaffInfo_SearchStaff_Position_GridTable.Name = "StaffInfo_SearchStaff_Position_GridTable";
            // 
            // StaffInfo_SearchStaff_PhoneNumber_GridTable
            // 
            this.StaffInfo_SearchStaff_PhoneNumber_GridTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffInfo_SearchStaff_PhoneNumber_GridTable.HeaderText = "Số điện thoại";
            this.StaffInfo_SearchStaff_PhoneNumber_GridTable.Name = "StaffInfo_SearchStaff_PhoneNumber_GridTable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin chi tiết";
            // 
            // ConfigurationTab
            // 
            this.ConfigurationTab.Controls.Add(this.tabControl2);
            this.ConfigurationTab.Location = new System.Drawing.Point(4, 24);
            this.ConfigurationTab.Name = "ConfigurationTab";
            this.ConfigurationTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigurationTab.Size = new System.Drawing.Size(976, 533);
            this.ConfigurationTab.TabIndex = 6;
            this.ConfigurationTab.Text = "Cấu hình";
            this.ConfigurationTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.ConfigurationTab_BookStoreConfigurationTab);
            this.tabControl2.Controls.Add(this.ConfigurationTab_CustomerConfigurationTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(970, 527);
            this.tabControl2.TabIndex = 0;
            // 
            // ConfigurationTab_BookStoreConfigurationTab
            // 
            this.ConfigurationTab_BookStoreConfigurationTab.Controls.Add(this.ConfigurationTab_BookStoreConfigurationTab_MainContainer);
            this.ConfigurationTab_BookStoreConfigurationTab.Location = new System.Drawing.Point(4, 24);
            this.ConfigurationTab_BookStoreConfigurationTab.Name = "ConfigurationTab_BookStoreConfigurationTab";
            this.ConfigurationTab_BookStoreConfigurationTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigurationTab_BookStoreConfigurationTab.Size = new System.Drawing.Size(962, 499);
            this.ConfigurationTab_BookStoreConfigurationTab.TabIndex = 0;
            this.ConfigurationTab_BookStoreConfigurationTab.Text = "Cấu hình nhà sách";
            this.ConfigurationTab_BookStoreConfigurationTab.UseVisualStyleBackColor = true;
            // 
            // ConfigurationTab_CustomerConfigurationTab
            // 
            this.ConfigurationTab_CustomerConfigurationTab.Location = new System.Drawing.Point(4, 24);
            this.ConfigurationTab_CustomerConfigurationTab.Name = "ConfigurationTab_CustomerConfigurationTab";
            this.ConfigurationTab_CustomerConfigurationTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigurationTab_CustomerConfigurationTab.Size = new System.Drawing.Size(962, 499);
            this.ConfigurationTab_CustomerConfigurationTab.TabIndex = 1;
            this.ConfigurationTab_CustomerConfigurationTab.Text = "Cấu hình khách hàng";
            this.ConfigurationTab_CustomerConfigurationTab.UseVisualStyleBackColor = true;
            // 
            // ConfigurationTab_BookStoreConfigurationTab_MainContainer
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Name = "ConfigurationTab_BookStoreConfigurationTab_MainContainer";
            // 
            // ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.numericUpDown4);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.numericUpDown3);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.numericUpDown2);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.textBox5);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.label27);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.button1);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.label25);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.label26);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.label24);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.textBox1);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.Controls.Add(this.label23);
            // 
            // ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel2
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel2.Controls.Add(this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Size = new System.Drawing.Size(956, 493);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.SplitterDistance = 318;
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 89);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 15);
            this.label23.TabIndex = 4;
            this.label23.Text = "Tên cấu hình";
            // 
            // ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id,
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name,
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock,
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock,
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport});
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Name = "ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.RowTemplate.Height = 25;
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.Size = new System.Drawing.Size(634, 493);
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.TabIndex = 0;
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_CellContentClick);
            // 
            // ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id.HeaderText = "Id";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id.Name = "ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id";
            // 
            // ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name.HeaderText = "Tên cấu hình";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name.Name = "ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name.Width = 80;
            // 
            // ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock.HeaderText = "Số lượng tồn kho tối đa";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock.Name = "ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Maximum" +
    "Stock";
            // 
            // ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock.HeaderText = "Số lượng tồn kho tối thiểu";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock.Name = "ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Minimum" +
    "Stock";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock.Width = 80;
            // 
            // ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport
            // 
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport.HeaderText = "Số lượng sách nhập tối thiểu";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport.Name = "ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Minimum" +
    "BookImport";
            this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport.Width = 80;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 150);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 15);
            this.label24.TabIndex = 6;
            this.label24.Text = "Số lượng tồn kho tối đa";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 283);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(158, 15);
            this.label25.TabIndex = 10;
            this.label25.Text = "Số lượng sách nhập tối thiểu";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 222);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(145, 15);
            this.label26.TabIndex = 8;
            this.label26.Text = "Số lượng tồn kho tối thiểu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 23);
            this.textBox5.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(25, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 15);
            this.label27.TabIndex = 13;
            this.label27.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(25, 169);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(229, 23);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(25, 241);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(229, 23);
            this.numericUpDown3.TabIndex = 15;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(25, 302);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(229, 23);
            this.numericUpDown4.TabIndex = 15;
            // 
            // BookStoreUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainNav);
            this.Name = "BookStoreUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookStoreUILoad);
            this.MainNav.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab_MainContainer.Panel1.ResumeLayout(false);
            this.HomeTab_MainContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTab_MainContainer)).EndInit();
            this.HomeTab_MainContainer.ResumeLayout(false);
            this.ImportBookTab.ResumeLayout(false);
            this.ImportBookMenu_MainContainer.Panel1.ResumeLayout(false);
            this.ImportBookMenu_MainContainer.Panel1.PerformLayout();
            this.ImportBookMenu_MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImportBookMenu_MainContainer)).EndInit();
            this.ImportBookMenu_MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImportBookMenu_QueryBook_ImportQuantityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBookMenu_BooksDataGridView)).EndInit();
            this.QueryBookTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.QueryBookMenu_BookInfo_Tab.ResumeLayout(false);
            this.QueryBookMenu_QueryBookTab.Panel1.ResumeLayout(false);
            this.QueryBookMenu_QueryBookTab.Panel1.PerformLayout();
            this.QueryBookMenu_QueryBookTab.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueryBookMenu_QueryBookTab)).EndInit();
            this.QueryBookMenu_QueryBookTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookQuery_ListBooks)).EndInit();
            this.QueryBookMenu_AddBook_Tab.ResumeLayout(false);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.ResumeLayout(false);
            this.QueryBookMenu_AddBookTab_MainContainer.Panel1.PerformLayout();
            this.QueryBookMenu_AddBookTab_MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueryBookMenu_AddBookTab_MainContainer)).EndInit();
            this.QueryBookMenu_AddBookTab_MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView)).EndInit();
            this.SaleBookTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SellBookTab_MainContainer)).EndInit();
            this.SellBookTab_MainContainer.ResumeLayout(false);
            this.CustomerInfoTab.ResumeLayout(false);
            this.CustomerMenu_MainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMenu_MainContainer)).EndInit();
            this.CustomerMenu_MainContainer.ResumeLayout(false);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.ResumeLayout(false);
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel1.PerformLayout();
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMenu_MainContainer_QueryCustomerSubContainer)).EndInit();
            this.CustomerMenu_MainContainer_QueryCustomerSubContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMenu_QueryCustomer_CustomerDataGridView)).EndInit();
            this.StaffInfoTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffInfo_SearchStaff_StaffInfo_GridTable)).EndInit();
            this.ConfigurationTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ConfigurationTab_BookStoreConfigurationTab.ResumeLayout(false);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.ResumeLayout(false);
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel1.PerformLayout();
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationTab_BookStoreConfigurationTab_MainContainer)).EndInit();
            this.ConfigurationTab_BookStoreConfigurationTab_MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainNav;
        private TabPage ImportBookTab;
        private TabPage QueryBookTab;
        private TabPage SaleBookTab;
        private TabPage CustomerInfoTab;
        private TabPage StaffInfoTab;
        private TabPage HomeTab;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button StaffInfo_SearchStaff_Search_Button;
        private TextBox StaffInfo_SearchStaff_Position_Textbox;
        private TextBox StaffInfo_SearchStaff_Age_Textbox;
        private TextBox StaffInfo_SearchStaff_Name_Textbox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private DataGridView StaffInfo_SearchStaff_StaffInfo_GridTable;
        private DataGridViewTextBoxColumn StaffInfo_SearchStaff_Name_GridTable;
        private DataGridViewTextBoxColumn StaffInfo_SearchStaff_Address_GridTable;
        private DataGridViewTextBoxColumn StaffInfo_SearchStaff_Age_GridTable;
        private DataGridViewTextBoxColumn StaffInfo_SearchStaff_Position_GridTable;
        private DataGridViewTextBoxColumn StaffInfo_SearchStaff_PhoneNumber_GridTable;
        private SplitContainer CustomerMenu_MainContainer;
        private SplitContainer CustomerMenu_MainContainer_QueryCustomerSubContainer;
        private Button CustomerMenu_QueryCustomer_Search_Button;
        private TextBox CustomerMenu_QueryCustomer_FullName_Textbox;
        private Label label13;
        private TextBox CustomerMenu_QueryCustomer_Id_Textbox;
        private Label label12;
        private DataGridView CustomerMenu_QueryCustomer_CustomerDataGridView;
        private DataGridViewTextBoxColumn CustomerMenu_QueryCustomer_CustomerDataGridView_Id_Column;
        private DataGridViewTextBoxColumn CustomerMenu_QueryCustomer_CustomerDataGridView_FullName_Column;
        private DataGridViewTextBoxColumn CustomerMenu_QueryCustomer_CustomerDataGridView_Address_Column;
        private DataGridViewTextBoxColumn CustomerMenu_QueryCustomer_CustomerDataGridView_PhoneNumber_Column;
        private SplitContainer ImportBookMenu_MainContainer;
        private ComboBox ImportBookMenu_QueryBook_BookStore_ComboBox;
        private Label label14;
        private DataGridView ImportBookMenu_BooksDataGridView;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookCode;
        private DataGridViewTextBoxColumn BookType;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn Action;
        private TabPage ConfigurationTab;
        private TabControl tabControl1;
        private TabPage QueryBookMenu_BookInfo_Tab;
        private SplitContainer QueryBookMenu_QueryBookTab;
        private ComboBox QueryBook_BookType_ComboBox;
        private ComboBox QueryBook_Price_ComboBox;
        private Label label11;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label2;
        private TextBox QueryBook_AuthorName_TextBox;
        private TextBox QueryBook_BookCode_TextBox;
        private TextBox QueryBook_BookName_TextBox;
        private Button QueryBookMenu_BookInfo_SearchBook_Button;
        private DataGridView bookQuery_ListBooks;
        private DataGridViewTextBoxColumn BookQueryGrib_BookNameColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookCodeColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookTypeColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_AuthorNameColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookPriceColumn;
        private TabPage QueryBookMenu_AddBook_Tab;
        private SplitContainer QueryBookMenu_AddBookTab_MainContainer;
        private Label label17;
        private TextBox QueryBookMenu_AddBookTab_MainContainer_AddBook_BookNameTextBox;
        private ComboBox QueryBookMenu_AddBookTab_MainContainer_AddBook_AuthorComboBox;
        private Label label16;
        private ComboBox QueryBookMenu_AddBookTab_MainContainer_AddBook_BookTypesComboBox;
        private Label label15;
        private DataGridView QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView;
        private DataGridViewTextBoxColumn QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_IdColumn;
        private DataGridViewTextBoxColumn QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_NameColumn;
        private DataGridViewTextBoxColumn QueryBookMenu_AddBookTab_MainContainer_BooksDataGridView_AuthorName;
        private Button QueryBookMenu_AddBookTab_MainContainer_AddBook_AddButton;
        private Label label18;
        private TextBox QueryBookMenu_AddBookTab_MainContainer_AddBook_BookPriceTexBook;
        private ComboBox ImportBookMenu_QueryBook_BookNameComboBox;
        private Label label19;
        private Button ImportBookMenu_QueryBook_SubmitButton;
        private Label label20;
        private NumericUpDown ImportBookMenu_QueryBook_ImportQuantityNum;
        private SplitContainer HomeTab_MainContainer;
        private Label label22;
        private TextBox HomeTab_LoginContainer_PasswordTextBook;
        private Label label21;
        private TextBox HomeTab_LoginContainer_UserNameTextBox;
        private Button HomeTab_LoginContainer_LoginButton;
        private SplitContainer SellBookTab_MainContainer;
        private TabControl tabControl2;
        private TabPage ConfigurationTab_BookStoreConfigurationTab;
        private TabPage ConfigurationTab_CustomerConfigurationTab;
        private SplitContainer ConfigurationTab_BookStoreConfigurationTab_MainContainer;
        private Label label23;
        private DataGridView ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private TextBox textBox5;
        private Label label27;
        private Button button1;
        private Label label25;
        private Label label26;
        private Label label24;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Id;
        private DataGridViewTextBoxColumn ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_Name;
        private DataGridViewTextBoxColumn ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MaximumStock;
        private DataGridViewTextBoxColumn ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumStock;
        private DataGridViewTextBoxColumn ConfigurationTab_BookStoreConfigurationTab_StoreConfigurationDataGridView_MinimumBookImport;
    }
}