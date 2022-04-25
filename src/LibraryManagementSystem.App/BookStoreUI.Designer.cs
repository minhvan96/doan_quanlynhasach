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
            this.ImportBookTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryBookTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.searchBookBox = new System.Windows.Forms.TextBox();
            this.searchBoxButton = new System.Windows.Forms.Button();
            this.bookQuery_ListBooks = new System.Windows.Forms.DataGridView();
            this.SaleBookTab = new System.Windows.Forms.TabPage();
            this.CustomerInfoTab = new System.Windows.Forms.TabPage();
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
            this.BookQueryGrib_BookNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_AuthorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainNav.SuspendLayout();
            this.ImportBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.QueryBookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookQuery_ListBooks)).BeginInit();
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
            this.MainNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainNav.Location = new System.Drawing.Point(0, 0);
            this.MainNav.Name = "MainNav";
            this.MainNav.SelectedIndex = 0;
            this.MainNav.Size = new System.Drawing.Size(984, 561);
            this.MainNav.TabIndex = 1;
            // 
            // HomeTab
            // 
            this.HomeTab.Location = new System.Drawing.Point(4, 24);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(976, 533);
            this.HomeTab.TabIndex = 5;
            this.HomeTab.Text = "HOME";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // ImportBookTab
            // 
            this.ImportBookTab.Controls.Add(this.dataGridView1);
            this.ImportBookTab.Location = new System.Drawing.Point(4, 24);
            this.ImportBookTab.Name = "ImportBookTab";
            this.ImportBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportBookTab.Size = new System.Drawing.Size(976, 533);
            this.ImportBookTab.TabIndex = 0;
            this.ImportBookTab.Text = "Nhập sách";
            this.ImportBookTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BookCode,
            this.BookType,
            this.Available,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(219, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(539, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Tên sách";
            this.BookName.Name = "BookName";
            // 
            // BookCode
            // 
            this.BookCode.HeaderText = "Mã sách";
            this.BookCode.Name = "BookCode";
            // 
            // BookType
            // 
            this.BookType.HeaderText = "Loại sách";
            this.BookType.Name = "BookType";
            // 
            // Available
            // 
            this.Available.HeaderText = "Số lượng đã nhận";
            this.Available.Name = "Available";
            // 
            // Action
            // 
            this.Action.HeaderText = "Thao tác";
            this.Action.Name = "Action";
            // 
            // QueryBookTab
            // 
            this.QueryBookTab.Controls.Add(this.splitContainer3);
            this.QueryBookTab.Location = new System.Drawing.Point(4, 24);
            this.QueryBookTab.Name = "QueryBookTab";
            this.QueryBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.QueryBookTab.Size = new System.Drawing.Size(976, 533);
            this.QueryBookTab.TabIndex = 1;
            this.QueryBookTab.Text = "Tra cứu sách";
            this.QueryBookTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.searchBookBox);
            this.splitContainer3.Panel1.Controls.Add(this.searchBoxButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.bookQuery_ListBooks);
            this.splitContainer3.Size = new System.Drawing.Size(970, 527);
            this.splitContainer3.SplitterDistance = 100;
            this.splitContainer3.TabIndex = 3;
            // 
            // searchBookBox
            // 
            this.searchBookBox.Location = new System.Drawing.Point(72, 50);
            this.searchBookBox.Name = "searchBookBox";
            this.searchBookBox.Size = new System.Drawing.Size(195, 23);
            this.searchBookBox.TabIndex = 0;
            // 
            // searchBoxButton
            // 
            this.searchBoxButton.Location = new System.Drawing.Point(273, 50);
            this.searchBoxButton.Name = "searchBoxButton";
            this.searchBoxButton.Size = new System.Drawing.Size(75, 23);
            this.searchBoxButton.TabIndex = 1;
            this.searchBoxButton.Text = "Tìm kiếm";
            this.searchBoxButton.UseVisualStyleBackColor = true;
            this.searchBoxButton.Click += new System.EventHandler(this.searchBoxButton_Click);
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
            this.bookQuery_ListBooks.Size = new System.Drawing.Size(970, 423);
            this.bookQuery_ListBooks.TabIndex = 2;
            this.bookQuery_ListBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookQuery_ListBooks_CellContentClick);
            // 
            // SaleBookTab
            // 
            this.SaleBookTab.Location = new System.Drawing.Point(4, 24);
            this.SaleBookTab.Name = "SaleBookTab";
            this.SaleBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.SaleBookTab.Size = new System.Drawing.Size(976, 533);
            this.SaleBookTab.TabIndex = 2;
            this.SaleBookTab.Text = "Bán sách";
            this.SaleBookTab.UseVisualStyleBackColor = true;
            // 
            // CustomerInfoTab
            // 
            this.CustomerInfoTab.Location = new System.Drawing.Point(4, 24);
            this.CustomerInfoTab.Name = "CustomerInfoTab";
            this.CustomerInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerInfoTab.Size = new System.Drawing.Size(976, 533);
            this.CustomerInfoTab.TabIndex = 3;
            this.CustomerInfoTab.Text = "Khách hàng";
            this.CustomerInfoTab.UseVisualStyleBackColor = true;
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
            // BookStoreUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainNav);
            this.Name = "BookStoreUI";
            this.Text = "Form1";
            this.MainNav.ResumeLayout(false);
            this.ImportBookTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.QueryBookTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookQuery_ListBooks)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainNav;
        private TabPage ImportBookTab;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookCode;
        private DataGridViewTextBoxColumn BookType;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn Action;
        private TabPage QueryBookTab;
        private DataGridView bookQuery_ListBooks;
        private Button searchBoxButton;
        private TextBox searchBookBox;
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
        private SplitContainer splitContainer3;
        private DataGridViewTextBoxColumn BookQueryGrib_BookNameColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookCodeColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookTypeColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_AuthorNameColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookPriceColumn;
    }
}