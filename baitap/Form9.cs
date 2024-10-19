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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string song = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(song);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string song=listBox1.SelectedItem.ToString();
            //listBox2.Items.Add(song);
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string song = listBox2.SelectedItem.ToString();
            listBox1.Items.Add(song);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string song = listBox1.Items[i].ToString();
                listBox2.Items.Add(song);
                listBox1.Items.RemoveAt(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string song = listBox2.Items[i].ToString();
                listBox1.Items.Add(song);
                listBox2.Items.RemoveAt(i);
            }
        }
    }
}
