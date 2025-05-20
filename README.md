# WindowsFormsApp1
⚙️ Hướng dẫn cài đặt – Installation Guide
🔹 Tiếng Việt
1. Tải và cài đặt SQL Server
Cài bản SQL Server Express hoặc Developer Edition.
Ghi nhớ tên server SQL của bạn, ví dụ: FUONGTWAN, .\SQLEXPRESS, v.v.
2. Tạo cơ sở dữ liệu
Mở SQL Server Management Studio (SSMS).
Mở file database.sql (có trong thư mục project).
Nhấn Execute (F5) để chạy toàn bộ script và tạo cơ sở dữ liệu dbms_mypham cùng các bảng cần thiết.
Cấu hình chuỗi kết nối (connection string)
3. Mở project trong Visual Studio.
Tìm đến file có chứa dòng kết nối SqlConnection.
Thay Data Source=... bằng tên server SQL của bạn.
Ví dụ:
SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True");
4. Chạy chương trình
Nhấn F5 hoặc Ctrl + F5 để chạy ứng dụng.
Thực hiện các thao tác thêm sản phẩm, tạo đơn hàng, tìm kiếm, thống kê.
-----------------------
🔹 English
1. Install SQL Server
Install SQL Server Express or Developer Edition.
Note your SQL Server name, e.g., FUONGTWAN, .\SQLEXPRESS, etc.
2. Create the database
Open SQL Server Management Studio (SSMS).
Open the file database.sql included in this project.
Press Execute (F5) to run the script and create dbms_mypham database with required tables.
Edit connection string
3. Open the project in Visual Studio.
Locate the line where SqlConnection is initialized.
Change the Data Source= to your actual SQL Server name.
Example:
SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True");
4. Run the application
Press F5 or Ctrl + F5 in Visual Studio.
Use the interface to manage products, create orders, search, and view statistics.
