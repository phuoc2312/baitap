using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form11 : Form
    {
        List<Employee> lst; // Danh sách nhân viên

        public Form11()
        {
            InitializeComponent();
            lst = GetData(); // Khởi tạo danh sách nhân viên từ dữ liệu cứng
            LoadDataGridView(); // Tải dữ liệu vào DataGridView
        }

        // Phương thức khởi tạo danh sách nhân viên cứng
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            lst.Add(new Employee { Id = "53418", Name = "Mai huu phuoc", Age = 20, Gender = false });
            lst.Add(new Employee { Id = "53417", Name = "maihuuphuioc", Age = 25, Gender = true });
            lst.Add(new Employee { Id = "53416", Name = "phuocccccc", Age = 23, Gender = false });

            return lst;
        }

        // Phương thức để tải dữ liệu vào DataGridView
        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear(); // Xóa các dòng hiện tại

            // Điền dữ liệu vào DataGridView từ danh sách nhân viên
            foreach (var employee in lst)
            {
                dataGridView1.Rows.Add(employee.Id, employee.Name, employee.Age, employee.Gender);
            }
        }

        // Sự kiện khi click vào một ô trong DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng hợp lệ
            {
                int idx = e.RowIndex;

                // Điền thông tin vào các TextBox và Checkbox từ dòng đã chọn
                textBox1.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                checkBox1.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[3].Value.ToString());
            }
        }

        // Sự kiện khi nhấn nút thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int age))
            {
                Employee em = new Employee
                {
                    Id = textBox1.Text,
                    Name = textBox2.Text,
                    Age = age,
                    Gender = checkBox1.Checked // Lưu trạng thái của checkbox
                };

                // Cập nhật danh sách và DataGridView
                lst.Add(em);
                LoadDataGridView(); // Tải lại DataGridView
                ClearTextBoxes(); // Xóa thông tin trên các TextBox sau khi thêm
            }
            else
            {
                MessageBox.Show("Please enter a valid age."); // Thông báo nếu tuổi không hợp lệ
            }
        }

        // Sự kiện khi nhấn nút xóa
        private void button3_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex; // Lấy chỉ số hàng hiện tại
            if (idx >= 0)
            {
                lst.RemoveAt(idx); // Xóa khỏi danh sách
                LoadDataGridView(); // Cập nhật DataGridView
            }
        }

        // Xóa thông tin trên các TextBox
        private void ClearTextBoxes()
        {
            textBox1.Clear(); // Xóa TextBox Id
            textBox2.Clear(); // Xóa TextBox Name
            textBox3.Clear(); // Xóa TextBox Age
            checkBox1.Checked = false; // Đặt trạng thái Checkbox về mặc định
        }
    }

    // Định nghĩa lớp Employee
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
}
