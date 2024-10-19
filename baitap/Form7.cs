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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    textBox2.Enabled = true;

                }
                else
                    textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string msg = null;
                int disc = 0;
                if (radioButton1.Checked == true)
                    msg += "Ông ";
                if (radioButton2.Checked == true)
                    msg += "Bà ";
                if (checkBox1.Checked == true)
                    disc = 5;
                textBox3.Text = msg + textBox1.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
            }
        }
    }
}
