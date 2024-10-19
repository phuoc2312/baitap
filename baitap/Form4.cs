using System;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form4 : Form
    {
        // Biến dùng để lưu trữ giá trị tạm thời
        decimal workingMemory = 0;

        // Biến lưu toán tử hiện tại
        string opr = "";

        // Biến nhớ của máy tính (Memory)
        decimal memory = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Sự kiện thay đổi nội dung TextBox
        }

        // Sự kiện click của tất cả các nút số và chức năng
        private void button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // Nếu là số hoặc dấu chấm thập phân
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                textBox1.Text += bt.Text;
            }
            // Nếu là các phép toán +, -, *, /
            else if (bt.Text == "+" || bt.Text == "-" || bt.Text == "*" || bt.Text == "/")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(textBox1.Text);
                textBox1.Clear();
            }
            // Nếu là dấu "="
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(textBox1.Text);

                if (opr == "+")
                {
                    textBox1.Text = (workingMemory + secondValue).ToString();
                }
                else if (opr == "-")
                {
                    textBox1.Text = (workingMemory - secondValue).ToString();
                }
                else if (opr == "*")
                {
                    textBox1.Text = (workingMemory * secondValue).ToString();
                }
                else if (opr == "/")
                {
                    if (secondValue != 0)
                    {
                        textBox1.Text = (workingMemory / secondValue).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0.");
                    }
                }
            }
            // Đảo dấu ±
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                currVal = -currVal;
                textBox1.Text = currVal.ToString();
            }
            // Căn bậc hai √
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                textBox1.Text = currVal.ToString();
            }
            // Phần trăm %
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                currVal = currVal / 100;
                textBox1.Text = currVal.ToString();
            }
            // 1/x
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    textBox1.Text = currVal.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0.");
                }
            }
            // Xóa một ký tự
            else if (bt.Text == "<-")
            {
                if (textBox1.TextLength != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
            }
            // Bộ nhớ: xóa MC, đọc MR, lưu MS, cộng vào bộ nhớ M+, trừ khỏi bộ nhớ M-
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                textBox1.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(textBox1.Text);
                textBox1.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(textBox1.Text);
            }
            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(textBox1.Text);
            }
            // Xóa tất cả (C) hoặc chỉ giá trị hiện tại (CE)
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                textBox1.Clear();
            }
            else if (bt.Text == "CE")
            {
                textBox1.Clear();
            }
        }
    }
}
