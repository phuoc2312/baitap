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
    public partial class Form12 : Form
    {
        private Timer timer; // Đối tượng Timer
        private TimeSpan timeSpan; // Biến để lưu trữ thời gian
        public Form12()
        {
            InitializeComponent();
            InitializeTimer();
            
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
        private void InitializeTimer()
        {
            timer = new Timer(); // Khởi tạo Timer
            timer.Interval = 1000; // Thiết lập thời gian là 1 giây (1000 ms)
            timer.Tick += timer1_Tick; // Gán sự kiện Tick cho Timer
            timeSpan = TimeSpan.Zero; // Khởi tạo timeSpan về 0
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSpan = timeSpan.Add(TimeSpan.FromSeconds(1)); // Tăng timeSpan thêm 1 giây
            labelTime.Text = timeSpan.ToString(@"hh\:mm\:ss"); // Cập nhật label hiển thị thời gian
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
