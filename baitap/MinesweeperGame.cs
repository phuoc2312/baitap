using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap
{
    public partial class MinesweeperGame : Form
    {
        private const int width = 10;  // Số cột
        private const int height = 10; // Số hàng
        private const int mineCount = 10;  // Số lượng mìn

        private Button[,] buttons;  // Mảng chứa các ô nút
        private bool[,] mines;      // Mảng chứa mìn
        private bool[,] flags;      // Mảng chứa trạng thái cờ

        public MinesweeperGame()
        {
            InitializeComponent();
        }

        private void MinesweeperGame_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[width, height];
            mines = new bool[width, height];
            flags = new bool[width, height];

            panelGameBoard.Controls.Clear();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(x * 30, y * 30);
                    btn.Tag = new Point(x, y); // Lưu vị trí của button trong mảng
                    btn.MouseDown += new MouseEventHandler(Button_MouseDown); // Gắn sự kiện chuột
                    panelGameBoard.Controls.Add(btn);
                    buttons[x, y] = btn;
                }
            }
            PlaceMines();  // Đặt mìn ngẫu nhiên
        }

        private void PlaceMines()
        {
            Random rand = new Random();
            int minesPlaced = 0;

            while (minesPlaced < mineCount)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                if (!mines[x, y])
                {
                    mines[x, y] = true;
                    minesPlaced++;
                }
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            Point location = (Point)btn.Tag;
            int x = location.X;
            int y = location.Y;

            if (e.Button == MouseButtons.Right)
            {
                // Đặt hoặc gỡ cờ
                if (!flags[x, y] && btn.Text == "")
                {
                    btn.Text = "⚑"; // Đặt cờ
                    flags[x, y] = true;
                }
                else if (flags[x, y])
                {
                    btn.Text = ""; // Gỡ cờ
                    flags[x, y] = false;
                }
            }
            else if (e.Button == MouseButtons.Left && !flags[x, y])
            {
                // Mở ô nếu không có cờ
                OpenCell(x, y);
                CheckWinCondition();
            }
        }

        private void OpenCell(int x, int y)
        {
            if (mines[x, y])
            {
                // Nếu ô chứa mìn, kết thúc trò chơi
                buttons[x, y].Text = "X";
                buttons[x, y].BackColor = Color.Red; // Highlight ô mìn
                MessageBox.Show("Boom! Bạn thua rồi.");
                RestartGame();
            }
            else
            {
                int mineCount = CountMinesAround(x, y);
                buttons[x, y].Text = mineCount.ToString();
                buttons[x, y].Enabled = false;

                if (mineCount == 0)
                {
                    // Nếu không có mìn xung quanh, tự động mở các ô xung quanh
                    OpenAdjacentCells(x, y);
                }
            }
        }

        private int CountMinesAround(int x, int y)
        {
            int count = 0;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx >= 0 && nx < width && ny >= 0 && ny < height && mines[nx, ny])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void OpenAdjacentCells(int x, int y)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx >= 0 && nx < width && ny >= 0 && ny < height && buttons[nx, ny].Enabled)
                    {
                        OpenCell(nx, ny);
                    }
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitializeGame(); // Khởi tạo lại trò chơi
            lblMinesLeft.Text = "Mines Left: 10"; // Đặt lại số mìn
        }

        private void CheckWinCondition()
        {
            bool hasWon = true;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (!mines[i, j] && buttons[i, j].Enabled)
                    {
                        hasWon = false;
                        break;
                    }
                }
            }

            if (hasWon)
            {
                MessageBox.Show("Chúc mừng! Bạn đã thắng.");
                RestartGame();
            }
        }

        private void RestartGame()
        {
            // Thiết lập lại trò chơi sau khi kết thúc
            InitializeGame();
        }
    }
}
