using System;
using System.Windows.Forms;

namespace baitap
{
    public partial class login : Form
    {
        // Tài khoản và mật khẩu gán cứng
        private const string validUsername = "11";
        private const string validPassword = "111";

        public login()
        {
            InitializeComponent();
        }

        // Sự kiện khi nút Đăng nhập được nhấn
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ ô nhập liệu
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra tài khoản và mật khẩu
            if (username == validUsername && password == validPassword)
            {
               

                // Mở form chính và ẩn form đăng nhập
                this.Hide(); // Ẩn form đăng nhập
                menu mainForm = new menu(); // Tạo một instance của form chính
                mainForm.ShowDialog(); // Hiển thị form chính

                // Đóng form đăng nhập sau khi form chính đóng
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
