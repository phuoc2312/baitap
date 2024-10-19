using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace baitap
{
    public partial class Form5 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kq.Text += b0.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kq.Text += b1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kq.Text += b2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kq.Text += b3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opr = cong.Text;
            workingMemory = decimal.Parse(kq.Text);
            kq.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opr = nhan.Text;
            workingMemory = decimal.Parse(kq.Text);
            kq.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kq.Text += cham.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal seconValue = decimal.Parse(kq.Text);
            if (opr == "+")
                kq.Text = (workingMemory + seconValue).ToString();
            if (opr == "*")
                kq.Text = (workingMemory * seconValue).ToString();
            opr = "";
            workingMemory = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
