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
using MySql.Data.MySqlClient; // Sử dụng MySQL

namespace baitap
{
    public partial class csdl : Form
    {
        public csdl()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới MySQL trong XAMPP
            string connString = "Server=localhost;Database=C##;User Id=root;Password=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            string connString = @"Server=localhost;Database=C##;User Id=root;Password=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO customer (id, name) VALUES (@id, @name)", conn);
                cmd.Parameters.AddWithValue("@id", tbId.Text);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối đến MySQL
            string connString = @"Server=localhost;Database=C##;User Id=root;Password=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                // Câu lệnh SQL để cập nhật cả id và name
                MySqlCommand cmd = new MySqlCommand("UPDATE customer SET id=@newId, name=@name WHERE id=@oldId", conn);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@newId", tbId.Text);  // ID mới từ ô tbId
                cmd.Parameters.AddWithValue("@name", tbName.Text); // Tên mới từ ô tbName
                cmd.Parameters.AddWithValue("@oldId", dgvCustomer.CurrentRow.Cells[0].Value.ToString()); // ID cũ từ dòng hiện tại

                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                conn.Close();

                // Lấy chỉ số dòng hiện tại
                int idx = dgvCustomer.CurrentCell.RowIndex;

                // Cập nhật cả ID và tên trong DataGridView
                dgvCustomer.Rows[idx].Cells[0].Value = tbId.Text;  // Cập nhật ID
                dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text; // Cập nhật tên
            }
        }



        private void btDelete_Click_1(object sender, EventArgs e)
        {
            // Chuỗi kết nối đến MySQL
            string connString = @"Server=localhost;Database=C##;User Id=root;Password=;";

            // Kiểm tra xem một dòng có được chọn trong DataGridView hay không
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng hiện tại từ DataGridView
                int selectedRowIndex = dgvCustomer.SelectedRows[0].Index;

                // Lấy giá trị ID của dòng hiện tại
                string customerId = dgvCustomer.Rows[selectedRowIndex].Cells[0].Value.ToString();

                // In ra ID để kiểm tra
                MessageBox.Show("ID khách hàng cần xóa: " + customerId);

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    // Câu lệnh xóa từ cơ sở dữ liệu dựa trên ID
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM customer WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", customerId);

                    // Thực hiện lệnh xóa và kiểm tra số dòng bị ảnh hưởng
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Xóa dòng khỏi DataGridView
                        dgvCustomer.Rows.RemoveAt(selectedRowIndex);

                        // Xóa thông tin từ tbId và tbName
                        tbId.Text = string.Empty;
                        tbName.Text = string.Empty;

                        // Hiển thị thông báo đã xóa thành công
                        MessageBox.Show("Đã xóa thành công khách hàng.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với ID đã cho.");
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
