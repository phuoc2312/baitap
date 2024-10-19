using System;
using System.Collections;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            Song s = new Song();
            s.Id = 271;
            s.Name = "Như một giấc mơ ";
            s.Author = "Mỹ Tâm";
            lst.Add(s);

            s = new Song();
            s.Id = 272;
            s.Name = "Nhắm mắt thấy mùa hè";
            s.Author = "Nguyen Hà";
            lst.Add(s);

            s = new Song();
            s.Id = 273;
            s.Name = "Say yes to heaven";
            s.Author = "Đức mẹ Del Rey";
            lst.Add(s);

            return lst;
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            listBox1.DataSource = lst;
            listBox1.DisplayMember = "Name";
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            Song song = (Song)listBox1.SelectedItem;
            string id = song.Id.ToString();
            string name = song.Name.ToString();
            string author = song.Author.ToString();
            listBox2.Items.Add(id + " - " + name + " - " + author);
            //listBox1.Items.Remove(id + " - " + name + " - " + author);
            //listBox1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Song song = (Song)listBox2.SelectedItem;
            string id = song.Id.ToString();
            string name = song.Name.ToString();
            string author = song.Author.ToString();
            listBox1.Items.Add(id + " - " + name + " - " + author);
            //listBox2.Items.Remove(id + " - " + name + " - " + author);
        }

     
    }
}
