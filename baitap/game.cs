using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SnakeGame
{
    public partial class game : Form
    {
        private List<Point> snake = new List<Point>(); // Danh sách tọa độ của rắn
        private Point food; // Tọa độ của mồi
        private string direction = "right"; // Hướng di chuyển ban đầu của rắn
        private int score = 0; // Điểm số
        private Timer gameTimer = new Timer();
        private int cellSize = 20; // Kích thước mỗi ô (rắn, mồi)

        public game()
        {
            InitializeComponent();
            InitializeGame();
            this.KeyDown += Form1_KeyDown; // Gán sự kiện KeyDown cho form
        }

        // Khởi tạo game
        private void InitializeGame()
        {
            gameTimer.Interval = 100; // Tốc độ của game (100ms)
            gameTimer.Tick += GameLoop;

            StartGame();
        }

        // Bắt đầu game
        private void StartGame()
        {
            snake.Clear();
            snake.Add(new Point(10, 10)); // Khởi tạo vị trí ban đầu của rắn
            GenerateFood(); // Tạo mồi
            score = 0;
            direction = "right";
            gameTimer.Start();
        }

        // Tạo mồi ở vị trí ngẫu nhiên
        private void GenerateFood()
        {
            Random rand = new Random();
            int x = rand.Next(0, gamePanel.Width / cellSize);
            int y = rand.Next(0, gamePanel.Height / cellSize);
            food = new Point(x, y);
        }

        // Vòng lặp game (di chuyển rắn, kiểm tra va chạm, cập nhật UI)
        private void GameLoop(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            gamePanel.Invalidate(); // Vẽ lại panel
        }

        // Di chuyển rắn
        private void MoveSnake()
        {
            Point head = snake[0]; // Lấy đầu rắn

            // Tính vị trí mới cho đầu rắn
            Point newHead = head;
            if (direction == "up")
                newHead.Y--;
            else if (direction == "down")
                newHead.Y++;
            else if (direction == "left")
                newHead.X--;
            else if (direction == "right")
                newHead.X++;

            // Thêm vị trí mới vào đầu danh sách rắn
            snake.Insert(0, newHead);

            // Kiểm tra xem rắn có ăn mồi không
            if (newHead == food)
            {
                score++;
                scoreLabel.Text = $"Score: {score}";
                GenerateFood();
            }
            else
            {
                // Nếu không ăn mồi thì xóa phần cuối (đuôi) của rắn để giữ nguyên độ dài
                snake.RemoveAt(snake.Count - 1);
            }
        }

        // Kiểm tra va chạm
        private void CheckCollision()
        {
            Point head = snake[0];

            // Va chạm với tường
            if (head.X < 0 || head.Y < 0 || head.X >= gamePanel.Width / cellSize || head.Y >= gamePanel.Height / cellSize)
            {
                GameOver();
            }

            // Va chạm với chính mình
            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    GameOver();
                }
            }
        }

        // Kết thúc game
        // Kết thúc game
        private void GameOver()
        {
            gameTimer.Stop();

            // Hiển thị hộp thoại với nút "Thoát"
            DialogResult result = MessageBox.Show($"Game Over! Final Score: {score}\nBạn có muốn thoát trò chơi?",
                                                    "Kết thúc trò chơi",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng cửa sổ và thoát trò chơi
            }
            else
            {
                StartGame(); // Bắt đầu lại game nếu không muốn thoát
            }
        }


        // Bắt sự kiện bàn phím để điều khiển rắn
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && direction != "down")
                direction = "up";
            else if (e.KeyCode == Keys.Down && direction != "up")
                direction = "down";
            else if (e.KeyCode == Keys.Left && direction != "right")
                direction = "left";
            else if (e.KeyCode == Keys.Right && direction != "left")
                direction = "right";
        }

        // Vẽ rắn và mồi lên panel
        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Point part in snake)
            {
                // Tạo hình tròn cho mỗi phần của rắn
                Rectangle rect = new Rectangle(part.X * cellSize, part.Y * cellSize, cellSize, cellSize);

                // Vẽ hình tròn cho thân rắn
                using (SolidBrush brush = new SolidBrush(Color.Green))
                {
                    g.FillEllipse(brush, rect);
                }

                // Viền rắn
                g.DrawEllipse(new Pen(Color.DarkGreen, 2), rect);
            }

            // Vẽ mồi (giữ nguyên như cũ)
            Rectangle foodRect = new Rectangle(food.X * cellSize, food.Y * cellSize, cellSize, cellSize);
            using (SolidBrush foodBrush = new SolidBrush(Color.Red))
            {
                g.FillEllipse(foodBrush, foodRect);
            }
            g.DrawEllipse(new Pen(Color.DarkRed, 2), foodRect); // Viền mồi
        }


        private void game_Load(object sender, EventArgs e)
        {
            // Mã khởi tạo khi form load (có thể để trống nếu chưa cần thực hiện gì)
        }
    }
}
