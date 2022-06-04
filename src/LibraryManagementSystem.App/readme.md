Kết nối DB
Sửa connectionString tại file BookStoreContext.cs tại method OnConfiguring(DbContextOptionsBuilder optionsBuilder) (folder src/Infrastructure/BookStoreContext.cs)
Sửa đúng connectionString thì start app sẽ có dữ liệu mẫu đơn gồm mấy dữ liệu đơn giản

### Tài khoản
Có 3 loại tài khoản
  - Quản lý
  - Bán hàng
  - Nhân viên kho

Thông tin tài khoản chứa trong file Users.csv (Folder src/Setup/Users.csv)

Danh sách tài khoản bao gồm (taikhoan:matkhau)
  - quanly:123456
  - banhang1:123456
  - banhang2:123456
  - nhanvienkho:123456

Chức năng được chia theo role của user, ví dụ
  - User có role quanly sẽ thực hiện được chức năng tra cứu sách, xem báo cáo
  - User có role nhanvienkho sẽ thực hiện chức năng nhập sách
  - User có role banhang sẽ thực hiện được chức năng bán sách

