using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTriggerInfo();
            LoadRevenueByMonth();
            LoadProductsInStock();
            LoadCustomerPurchaseHistory();
            LoadCustomerData();
            LoadProductData();
            LoadOrderData();
            LoadOrderDetailData();
        }

        private void LoadTriggerInfo()
        {
            txtTriggerInfo.Text =
            @"🔁 Trigger đang kích hoạt:
            - trg_DecreaseStock_AfterInsertOrderDetails: Tự động trừ kho khi thêm sản phẩm vào đơn hàng.
            - trg_Restock_OnOrderCancelled: Tự động cộng lại kho nếu đơn bị hủy.
            - trg_CheckStock_BeforeInsertOrderDetails: Chặn đặt hàng nếu tồn kho không đủ.";
        }
        private void LoadRevenueByMonth()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=fuongtwan;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM vw_RevenueByMonth";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRevenue.DataSource = dt;
            }
        }
        private void LoadProductsInStock()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=fuongtwan;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM vw_ProductsInStock";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInStock.DataSource = dt;
            }
        }
        private void LoadCustomerPurchaseHistory()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=fuongtwan;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM vw_CustomerPurchaseHistory";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPurchaseHistory.DataSource = dt;
            }
        }




        private void LoadCustomerData()
        {
            dgvCustomer.Rows.Clear();
            dgvCustomer.Columns.Clear();

            dgvCustomer.Columns.Add("CustomerID", "Mã KH");
            dgvCustomer.Columns.Add("FullName", "Họ tên");
            dgvCustomer.Columns.Add("Email", "Email");
            dgvCustomer.Columns.Add("Password", "Mật khẩu");
            dgvCustomer.Columns.Add("PhoneNumber", "SĐT");
            dgvCustomer.Columns.Add("Address", "Địa chỉ");
            dgvCustomer.Columns.Add("CreatedAt", "Ngày tạo");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(
                        reader["CustomerID"],
                        reader["FullName"],
                        reader["Email"],
                        reader["Password"],
                        reader["PhoneNumber"],
                        reader["Address"],
                        Convert.ToDateTime(reader["CreatedAt"]).ToString("yyyy-MM-dd HH:mm")
                    );
                }

                reader.Close();
            }
        }



        private void btnThemCustomer_Click(object sender, EventArgs e)
        {
            // Tạo form thêm mới khách hàng
            addCustomer addForm = new addCustomer();
            addForm.FormClosed += (s, args) => LoadCustomerData(); // sau khi đóng form thì reload danh sách
            addForm.ShowDialog();
        }
        private void dgvCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // đảm bảo không phải header
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                int customerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                string fullName = row.Cells["FullName"].Value?.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string password = row.Cells["Password"].Value?.ToString();
                string phone = row.Cells["PhoneNumber"].Value?.ToString();
                string address = row.Cells["Address"].Value?.ToString();

                using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
                {
                    string query = @"UPDATE Customers 
                             SET FullName = @FullName, Email = @Email, Password = @Password,
                                 PhoneNumber = @PhoneNumber, Address = @Address
                             WHERE CustomerID = @CustomerID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã cập nhật thông tin khách hàng.", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy hàng đang chọn
                DataGridViewRow selectedRow = dgvCustomer.SelectedRows[0];
                int customerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.ExecuteNonQuery();
                    }

                    // Cập nhật lại bảng
                    LoadCustomerData();
                    MessageBox.Show("Đã xóa khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuuCustomer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvCustomer.Rows)
                {
                    if (row.IsNewRow) continue;

                    try
                    {
                        int customerID = Convert.ToInt32(row.Cells["CustomerID"].Value);
                        string fullName = row.Cells["FullName"].Value?.ToString();
                        string email = row.Cells["Email"].Value?.ToString();
                        string password = row.Cells["Password"].Value?.ToString();
                        string phone = row.Cells["PhoneNumber"].Value?.ToString();
                        string address = row.Cells["Address"].Value?.ToString();

                        string query = @"UPDATE Customers 
                                 SET FullName = @FullName, Email = @Email, Password = @Password, 
                                     PhoneNumber = @PhoneNumber, Address = @Address
                                 WHERE CustomerID = @CustomerID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", fullName);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu dòng có CustomerID = " + row.Cells["CustomerID"].Value + "\n" + ex.Message,
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Đã lưu các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerData(); // Tải lại bảng sau khi lưu
            }
        }

        private void btnReloadCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerData(); // gọi lại hàm đã viết
            MessageBox.Show("Đã tải lại danh sách khách hàng.", "Tải lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTimKiemCustomer_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemCustomer.Text.Trim();

            dgvCustomer.Rows.Clear();
            dgvCustomer.Columns.Clear();

            dgvCustomer.Columns.Add("CustomerID", "Mã KH");
            dgvCustomer.Columns.Add("FullName", "Họ tên");
            dgvCustomer.Columns.Add("Email", "Email");
            dgvCustomer.Columns.Add("Password", "Mật khẩu");
            dgvCustomer.Columns.Add("PhoneNumber", "SĐT");
            dgvCustomer.Columns.Add("Address", "Địa chỉ");
            dgvCustomer.Columns.Add("CreatedAt", "Ngày tạo");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                string query = @"
            SELECT * FROM Customers
            WHERE FullName LIKE @kw OR Email LIKE @kw OR PhoneNumber LIKE @kw";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(
                        reader["CustomerID"],
                        reader["FullName"],
                        reader["Email"],
                        reader["Password"],
                        reader["PhoneNumber"],
                        reader["Address"],
                        Convert.ToDateTime(reader["CreatedAt"]).ToString("yyyy-MM-dd HH:mm")
                    );
                }

                reader.Close();
            }
        }

        private void LoadProductData()
        {

            dgvProduct.Rows.Clear();
            dgvProduct.Columns.Clear();

            dgvProduct.Columns.Add("ProductID", "Mã SP");
            dgvProduct.Columns.Add("ProductName", "Tên sản phẩm");
            dgvProduct.Columns.Add("Category", "Danh mục");
            dgvProduct.Columns.Add("Price", "Giá");
            dgvProduct.Columns.Add("StockQuantity", "Tồn kho");
            dgvProduct.Columns.Add("ImageURL", "Hình ảnh");
            dgvProduct.Columns.Add("Description", "Mô tả");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvProduct.Rows.Add(
                        reader["ProductID"],
                        reader["ProductName"],
                        reader["Category"],
                        reader["Price"],
                        reader["StockQuantity"],
                        reader["ImageURL"],
                        reader["Description"]
                    );
                }

                reader.Close();
            }
        }

        private void btnXoaProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];
                int productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.ExecuteNonQuery();
                    }

                    LoadProductData();
                    MessageBox.Show("Đã xóa sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemProduct_Click(object sender, EventArgs e)
        {
            // Tạo form thêm mới sản phẩm
            addProduct addForm = new addProduct();
            addForm.FormClosed += (s, args) => LoadProductData(); // sau khi đóng form thì reload danh sách
            addForm.ShowDialog();
        }

        private void btnLuuProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    if (row.IsNewRow) continue;

                    try
                    {
                        int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                        string name = row.Cells["ProductName"].Value?.ToString();
                        string category = row.Cells["Category"].Value?.ToString();
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                        string imageUrl = row.Cells["ImageURL"].Value?.ToString();
                        string description = row.Cells["Description"].Value?.ToString();

                        string query = @"UPDATE Products
                                 SET ProductName = @ProductName, Category = @Category, Price = @Price,
                                     StockQuantity = @StockQuantity, ImageURL = @ImageURL, Description = @Description
                                 WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", name);
                            cmd.Parameters.AddWithValue("@Category", category);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@StockQuantity", quantity);
                            cmd.Parameters.AddWithValue("@ImageURL", imageUrl);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.Parameters.AddWithValue("@ProductID", productID);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu sản phẩm ID = " + row.Cells["ProductID"].Value + "\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Đã lưu thay đổi sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductData();
            }
        }

        private void btnReloadProduct_Click(object sender, EventArgs e)
        {
            LoadProductData();
            MessageBox.Show("Đã tải lại danh sách sản phẩm.", "Tải lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTimKiemProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemProduct.Text.Trim();

            dgvProduct.Rows.Clear();
            dgvProduct.Columns.Clear();

            dgvProduct.Columns.Add("ProductID", "Mã SP");
            dgvProduct.Columns.Add("ProductName", "Tên sản phẩm");
            dgvProduct.Columns.Add("Category", "Danh mục");
            dgvProduct.Columns.Add("Price", "Giá");
            dgvProduct.Columns.Add("StockQuantity", "Tồn kho");
            dgvProduct.Columns.Add("ImageURL", "Hình ảnh");
            dgvProduct.Columns.Add("Description", "Mô tả");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                string query = @"SELECT * FROM Products
                         WHERE ProductName LIKE @kw OR Category LIKE @kw";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvProduct.Rows.Add(
                        reader["ProductID"],
                        reader["ProductName"],
                        reader["Category"],
                        reader["Price"],
                        reader["StockQuantity"],
                        reader["ImageURL"],
                        reader["Description"]
                    );
                }

                reader.Close();
            }
        }
        private void LoadOrderData()
        {
            dgvOrder.Rows.Clear();
            dgvOrder.Columns.Clear();

            dgvOrder.Columns.Add("OrderID", "Mã Đơn");
            dgvOrder.Columns.Add("CustomerID", "Mã KH");
            dgvOrder.Columns.Add("OrderDate", "Ngày đặt");
            dgvOrder.Columns.Add("TotalAmount", "Tổng tiền");
            dgvOrder.Columns.Add("Status", "Trạng thái");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvOrder.Rows.Add(
                        reader["OrderID"],
                        reader["CustomerID"],
                        Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd HH:mm"),
                        reader["TotalAmount"],
                        reader["Status"]
                    );
                }

                reader.Close();
            }
        }

        private void btnXoaOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells["OrderID"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=fuongtwan;Initial Catalog=dbms_mypham;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE OrderID = @OrderID", conn);
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadOrderData();
                    MessageBox.Show("Đã xóa đơn hàng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để xóa.");
            }
        }
        private void txtTimKiemOrder_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemOrder.Text.Trim();

            dgvOrder.Rows.Clear();
            dgvOrder.Columns.Clear();

            dgvOrder.Columns.Add("OrderID", "Mã Đơn");
            dgvOrder.Columns.Add("CustomerID", "Mã KH");
            dgvOrder.Columns.Add("OrderDate", "Ngày đặt");
            dgvOrder.Columns.Add("TotalAmount", "Tổng tiền");
            dgvOrder.Columns.Add("Status", "Trạng thái");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                string query = @"SELECT * FROM Orders 
                         WHERE CAST(OrderID AS NVARCHAR) LIKE @kw 
                            OR CAST(CustomerID AS NVARCHAR) LIKE @kw 
                            OR Status LIKE @kw";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvOrder.Rows.Add(
                        reader["OrderID"],
                        reader["CustomerID"],
                        Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd HH:mm"),
                        reader["TotalAmount"],
                        reader["Status"]
                    );
                }

                reader.Close();
            }
        }
        private void LoadOrderDetailData()
        {
            dgvOrderDetail.Rows.Clear();
            dgvOrderDetail.Columns.Clear();

            dgvOrderDetail.Columns.Add("OrderDetailID", "Mã CT");
            dgvOrderDetail.Columns.Add("OrderID", "Mã Đơn");
            dgvOrderDetail.Columns.Add("ProductID", "Mã SP");
            dgvOrderDetail.Columns.Add("Quantity", "Số lượng");
            dgvOrderDetail.Columns.Add("UnitPrice", "Đơn giá");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT * FROM OrderDetails";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvOrderDetail.Rows.Add(
                        reader["OrderDetailID"],
                        reader["OrderID"],
                        reader["ProductID"],
                        reader["Quantity"],
                        reader["UnitPrice"]
                    );
                }

                reader.Close();
            }
        }


        private void txtTimKiemOrderDetail_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemOrderDetail.Text.Trim();

            dgvOrderDetail.Rows.Clear();
            dgvOrderDetail.Columns.Clear();

            dgvOrderDetail.Columns.Add("OrderDetailID", "Mã CT");
            dgvOrderDetail.Columns.Add("OrderID", "Mã Đơn");
            dgvOrderDetail.Columns.Add("ProductID", "Mã SP");
            dgvOrderDetail.Columns.Add("Quantity", "Số lượng");
            dgvOrderDetail.Columns.Add("UnitPrice", "Đơn giá");

            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                string query = @"SELECT * FROM OrderDetails
                         WHERE CAST(OrderID AS NVARCHAR) LIKE @kw 
                            OR CAST(ProductID AS NVARCHAR) LIKE @kw";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvOrderDetail.Rows.Add(
                        reader["OrderDetailID"],
                        reader["OrderID"],
                        reader["ProductID"],
                        reader["Quantity"],
                        reader["UnitPrice"]
                    );
                }

                reader.Close();
            }
        }

        private void btnXoaOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                int detailId = Convert.ToInt32(dgvOrderDetail.SelectedRows[0].Cells["OrderDetailID"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa chi tiết đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM OrderDetails WHERE OrderDetailID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", detailId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadOrderDetailData();
                    MessageBox.Show("Đã xóa chi tiết đơn hàng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết đơn hàng để xóa.");
            }
        }
    }
}
