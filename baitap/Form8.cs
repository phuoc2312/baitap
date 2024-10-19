using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap
{
    public partial class Form8 : Form
    {
        private int disc = 1;
        public Form8()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            string ngaySinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string khoa = comboBox1.SelectedItem.ToString();

            if (radioButton1.Checked)
                msg += "-Giới tính: Nam";
            if (radioButton2.Checked)
                msg += "-Giới tính: Nữ";
            textBox1.Text += $"{disc}. {textBox2.Text}\r\n";
            textBox1.Text += msg + "\r\n";
            textBox1.Text += "-Ngày Sinh:" + ngaySinh + "\r\n";
            textBox1.Text += "-Khoa:" + khoa + "\r\n";
            disc++;
        }
    }
}
