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
using System.Security.Cryptography;
using System.Text;


namespace WindowsFormsApp1
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnThemCustomer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=FUONGTWAN;Initial Catalog=dbms_mypham;Integrated Security=True"))
            {
                conn.Open();
                string query = "INSERT INTO Customers (FullName, Email, Password, PhoneNumber, Address) VALUES (@FullName, @Email, @Password, @PhoneNumber, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", HashPassword(txtPassword.Text)); // Hash passowrd
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
                this.Close(); // đóng form sau khi thêm
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
