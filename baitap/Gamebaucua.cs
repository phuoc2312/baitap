using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace baitap
{
    public partial class Gamebaucua : Form
    {
        int tienNguoi = 100000; // Số tiền ban đầu của người chơi
        int tienMay = 99999999;   // Số tiền ban đầu của máy

        string[] ketQua = new string[3]; // Lưu kết quả xúc xắc
        string[] conVat = { "Bầu", "Cua", "Tôm", "Cá", "Gà", "Nai" }; // Các con vật

        Random random = new Random(); // Để quay xúc xắc ngẫu nhiên

        // Dictionary chứa đường dẫn đến các hình ảnh
         Dictionary<string, Image> hinhAnhConVat = new Dictionary<string, Image>
            {
                { "Bầu", Properties.Resources.bau }, // Sử dụng ảnh từ Resources
                { "Cua", Properties.Resources.cua },
                { "Tôm", Properties.Resources.tom },
                { "Cá", Properties.Resources.ca },
                { "Gà", Properties.Resources.ga },
                { "Nai", Properties.Resources.nai }
            };

        public Gamebaucua()
        {
            InitializeComponent();
            lblTienNguoi.Text = tienNguoi.ToString();
            lblTienMay.Text = tienMay.ToString();
            
        }

        private void TinhKetQua()
        {
            int tienThang = 0;
            int tienDat = 0;

            // Tính tiền cược của người chơi
            if (txtBau.Text != "") tienDat += int.Parse(txtBau.Text);
            if (txtCua.Text != "") tienDat += int.Parse(txtCua.Text);
            if (txtTom.Text != "") tienDat += int.Parse(txtTom.Text);
            if (txtCa.Text != "") tienDat += int.Parse(txtCa.Text);
            if (txtGa.Text != "") tienDat += int.Parse(txtGa.Text);
            if (txtNai.Text != "") tienDat += int.Parse(txtNai.Text);

            // Kiểm tra xem số tiền cược có lớn hơn số tiền hiện có không
            if (tienDat > tienNguoi)
            {
                MessageBox.Show("Số tiền cược không được lớn hơn số tiền hiện có!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thực hiện hàm nếu cược lớn hơn số tiền hiện có
            }

            // Kiểm tra kết quả và tính tiền thắng
            tienThang += TinhTienTheoConVat("Bầu", txtBau.Text);
            tienThang += TinhTienTheoConVat("Cua", txtCua.Text);
            tienThang += TinhTienTheoConVat("Tôm", txtTom.Text);
            tienThang += TinhTienTheoConVat("Cá", txtCa.Text);
            tienThang += TinhTienTheoConVat("Gà", txtGa.Text);
            tienThang += TinhTienTheoConVat("Nai", txtNai.Text);

            // Cập nhật số tiền người chơi và máy
            if (tienThang > 0) // Nếu người chơi thắng
            {
                tienNguoi += tienThang; // Cộng tiền thắng vào tài khoản người chơi
                tienMay -= tienThang;   // Trừ tiền thắng từ máy
            }
            else // Nếu người chơi thua
            {
                tienNguoi -= tienDat;   // Trừ tiền cược của người chơi
                tienMay += tienDat;     // Cộng tiền cược vào máy
            }

            // Cập nhật hiển thị số tiền của người chơi và máy
            lblTienNguoi.Text = tienNguoi.ToString();
            lblTienMay.Text = tienMay.ToString();

            // Kiểm tra nếu người chơi hết tiền
            if (tienNguoi <= 0)
            {
                MessageBox.Show("Bạn đã hết tiền!");
                btnRung.Enabled = false;
            }
        }


        // Hàm tính tiền theo con vật dựa vào số lần xuất hiện
        private int TinhTienTheoConVat(string conVat, string tienCuoc)
        {
            if (tienCuoc == "") return 0; // Không có tiền cược thì không tính

            int soLanXuatHien = 0;
            for (int i = 0; i < 3; i++)
            {
                if (ketQua[i] == conVat)
                {
                    soLanXuatHien++;
                }
            }

            // In ra số lần xuất hiện để kiểm tra
            Console.WriteLine($"Con {conVat} xuất hiện {soLanXuatHien} lần");

            // In ra tiền thắng được tính
            int tienThang = soLanXuatHien * int.Parse(tienCuoc);
            Console.WriteLine($"Tiền thắng cho {conVat}: {tienThang}");

            return tienThang;
        }


        private void btnRung_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người chơi có cược hay không
            int tienDat = 0;
            if (txtBau.Text != "") tienDat += int.Parse(txtBau.Text);
            if (txtCua.Text != "") tienDat += int.Parse(txtCua.Text);
            if (txtTom.Text != "") tienDat += int.Parse(txtTom.Text);
            if (txtCa.Text != "") tienDat += int.Parse(txtCa.Text);
            if (txtGa.Text != "") tienDat += int.Parse(txtGa.Text);
            if (txtNai.Text != "") tienDat += int.Parse(txtNai.Text);

            // Kiểm tra xem số tiền cược có lớn hơn số tiền hiện có không
            if (tienDat > tienNguoi)
            {
                MessageBox.Show("Số tiền cược không được lớn hơn số tiền hiện có!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thực hiện hàm nếu cược lớn hơn số tiền hiện có
            }

            // Quay 3 con vật ngẫu nhiên
            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(0, conVat.Length); // Chọn ngẫu nhiên từ 0 đến 5
                ketQua[i] = conVat[index]; // Lưu kết quả

                // Hiển thị hình ảnh tương ứng trong PictureBox
                if (i == 0)
                {
                    pbResult1.Image = hinhAnhConVat[ketQua[i]];
                }
                else if (i == 1)
                {
                    pbResult2.Image = hinhAnhConVat[ketQua[i]];
                }
                else if (i == 2)
                {
                    pbResult3.Image = hinhAnhConVat[ketQua[i]];
                }
            }

            // Tính toán kết quả thắng thua
            TinhKetQua();
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            // Reset các ô TextBox
            txtBau.Text = "0";
            txtCua.Text = "0";
            txtTom.Text = "0";
            txtCa.Text = "0";
            txtGa.Text = "0";
            txtNai.Text = "0";

            btnRung.Enabled = true; // Cho phép chơi tiếp

            // Xóa hình ảnh trong các PictureBox
            pbResult1.Image = null;
            pbResult2.Image = null;
            pbResult3.Image = null;

            // Reset tiền người chơi và máy
            tienNguoi = 100000; // Đặt lại số tiền người chơi
            tienMay = 99999999;   // Đặt lại số tiền máy

            // Cập nhật lại label hiển thị số tiền
            lblTienNguoi.Text = tienNguoi.ToString();
            lblTienMay.Text = tienMay.ToString();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
