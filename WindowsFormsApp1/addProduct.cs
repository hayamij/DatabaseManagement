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

namespace WindowsFormsApp1
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }



        private void btnThemProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string category = cbCategory.SelectedItem.ToString();
            decimal price;
            int quantity;
            string imageUrl = txtImageURL.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(name) || !decimal.TryParse(txtPrice.Text, out price) || !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng cho tên, giá và số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=fuongtwan;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = @"INSERT INTO Products (ProductName, Category, Price, StockQuantity, ImageURL, Description)
                         VALUES (@ProductName, @Category, @Price, @StockQuantity, @ImageURL, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductName", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@StockQuantity", quantity);
                cmd.Parameters.AddWithValue("@ImageURL", imageUrl);
                cmd.Parameters.AddWithValue("@Description", description);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã thêm sản phẩm mới!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            cbCategory.Items.AddRange(new string[]
            {
        "Sửa rửa mặt", "Chống nắng", "Dưỡng da", "Trang điểm",
        "Tẩy trang", "Dưỡng tóc", "Nước hoa", "Khác"
            });
            cbCategory.SelectedIndex = 0;
        }
    }
}
