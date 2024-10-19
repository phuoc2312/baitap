using SnakeGame;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr01= new Form1();
            fr01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr02= new Form2();
            fr02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr03= new Form3();
            fr03.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
      
            Form6 fr06 = new Form6();
            fr06.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fr05= new Form5();    
                fr05.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr04 = new Form4();
            fr04.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 fr07= new Form7();    
            fr07.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 fr08= new Form8();
            fr08.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form9 fr09= new Form9();
                fr09.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 fr10= new Form10();  
                fr10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            csdl fr11 = new csdl();
            fr11.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form11 fr12= new Form11();
            fr12.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form12 fr13= new Form12();
                fr13.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            game fr14= new game();
            fr14.Show();    
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form13 fr15= new Form13();
            fr15.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form14 fr16= new Form14();
            fr16.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Gamebaucua fr17= new Gamebaucua();
            fr17.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MinesweeperGame fr18= new MinesweeperGame();
            fr18.Show();
        }
    }
}
