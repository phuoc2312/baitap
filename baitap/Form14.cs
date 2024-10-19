using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form14 : Form
    {
        int x = 0, y = 0; // Biến lưu trữ vị trí hiện tại của PictureBox

        public Form14()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh đã chọn vào PictureBox
                picEmployeePhoto.Image = Image.FromFile(openFileDialog.FileName);
                picEmployeePhoto.SizeMode = PictureBoxSizeMode.StretchImage;

                // Đặt lại vị trí của PictureBox sau khi chọn ảnh
                picEmployeePhoto.Location = new Point(x, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Di chuyển PictureBox sang trái
            x -= 10;
            picEmployeePhoto.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Di chuyển PictureBox sang phải
            x += 10;
            picEmployeePhoto.Location = new Point(x, y);
        }
    }
}
