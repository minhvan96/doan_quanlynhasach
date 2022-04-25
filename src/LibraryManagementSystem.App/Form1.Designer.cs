namespace BookStoreManagementSystem
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.importBook = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryBook = new System.Windows.Forms.TabPage();
            this.bookQuery_ListBooks = new System.Windows.Forms.DataGridView();
            this.BookQueryGrib_BookNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_AuthorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQueryGrib_BookPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBoxButton = new System.Windows.Forms.Button();
            this.searchBookBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.importBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.queryBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookQuery_ListBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.importBook);
            this.tabControl1.Controls.Add(this.queryBook);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 1;
            // 
            // importBook
            // 
            this.importBook.Controls.Add(this.dataGridView1);
            this.importBook.Location = new System.Drawing.Point(4, 24);
            this.importBook.Name = "importBook";
            this.importBook.Padding = new System.Windows.Forms.Padding(3);
            this.importBook.Size = new System.Drawing.Size(976, 533);
            this.importBook.TabIndex = 0;
            this.importBook.Text = "Nhập sách";
            this.importBook.UseVisualStyleBackColor = true;
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
            // queryBook
            // 
            this.queryBook.Controls.Add(this.bookQuery_ListBooks);
            this.queryBook.Controls.Add(this.searchBoxButton);
            this.queryBook.Controls.Add(this.searchBookBox);
            this.queryBook.Location = new System.Drawing.Point(4, 24);
            this.queryBook.Name = "queryBook";
            this.queryBook.Padding = new System.Windows.Forms.Padding(3);
            this.queryBook.Size = new System.Drawing.Size(976, 533);
            this.queryBook.TabIndex = 1;
            this.queryBook.Text = "Tra cứu sách";
            this.queryBook.UseVisualStyleBackColor = true;
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
            this.bookQuery_ListBooks.Location = new System.Drawing.Point(104, 130);
            this.bookQuery_ListBooks.Name = "bookQuery_ListBooks";
            this.bookQuery_ListBooks.RowTemplate.Height = 25;
            this.bookQuery_ListBooks.Size = new System.Drawing.Size(581, 328);
            this.bookQuery_ListBooks.TabIndex = 2;
            // 
            // BookQueryGrib_BookNameColumn
            // 
            this.BookQueryGrib_BookNameColumn.HeaderText = "Tên sách";
            this.BookQueryGrib_BookNameColumn.Name = "BookQueryGrib_BookNameColumn";
            // 
            // BookQueryGrib_BookCodeColumn
            // 
            this.BookQueryGrib_BookCodeColumn.HeaderText = "Mã sách";
            this.BookQueryGrib_BookCodeColumn.Name = "BookQueryGrib_BookCodeColumn";
            // 
            // BookQueryGrib_BookTypeColumn
            // 
            this.BookQueryGrib_BookTypeColumn.HeaderText = "Loại sách";
            this.BookQueryGrib_BookTypeColumn.Name = "BookQueryGrib_BookTypeColumn";
            // 
            // BookQueryGrib_AuthorNameColumn
            // 
            this.BookQueryGrib_AuthorNameColumn.HeaderText = "Tên tác giả";
            this.BookQueryGrib_AuthorNameColumn.Name = "BookQueryGrib_AuthorNameColumn";
            // 
            // BookQueryGrib_BookPriceColumn
            // 
            this.BookQueryGrib_BookPriceColumn.HeaderText = "Giá sách";
            this.BookQueryGrib_BookPriceColumn.Name = "BookQueryGrib_BookPriceColumn";
            // 
            // searchBoxButton
            // 
            this.searchBoxButton.Location = new System.Drawing.Point(305, 48);
            this.searchBoxButton.Name = "searchBoxButton";
            this.searchBoxButton.Size = new System.Drawing.Size(75, 23);
            this.searchBoxButton.TabIndex = 1;
            this.searchBoxButton.Text = "Tìm kiếm";
            this.searchBoxButton.UseVisualStyleBackColor = true;
            this.searchBoxButton.Click += new System.EventHandler(this.searchBoxButton_Click);
            // 
            // searchBookBox
            // 
            this.searchBookBox.Location = new System.Drawing.Point(104, 48);
            this.searchBookBox.Name = "searchBookBox";
            this.searchBookBox.Size = new System.Drawing.Size(195, 23);
            this.searchBookBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.importBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.queryBook.ResumeLayout(false);
            this.queryBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookQuery_ListBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage importBook;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookCode;
        private DataGridViewTextBoxColumn BookType;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewTextBoxColumn Action;
        private TabPage queryBook;
        private DataGridView bookQuery_ListBooks;
        private DataGridViewTextBoxColumn BookQueryGrib_BookNameColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookCodeColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookTypeColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_AuthorNameColumn;
        private DataGridViewTextBoxColumn BookQueryGrib_BookPriceColumn;
        private Button searchBoxButton;
        private TextBox searchBookBox;
    }
}