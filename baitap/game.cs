using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMPLib; // Thư viện Windows Media Player

namespace SnakeGame
{
    public partial class game : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food;
        private List<Point> obstacles = new List<Point>();
        private string direction = "right";
        private int score = 0;
        private int level = 1;
        private int timeRemaining = 15;
        private Timer gameTimer = new Timer();
        private Timer countdownTimer = new Timer();
        private Timer flashTimer = new Timer(); // Hẹn giờ cho hiệu ứng nhấp nháy ở cấp độ 3
        private bool isDarkMode = false; // Chế độ nền tối
        private int cellSize = 20;
        private Random rand = new Random();
        private WindowsMediaPlayer eatSound;
        private WindowsMediaPlayer gameSound;
        private Image snakeHeadImage;
        private Image foodImage;
        private Image obstacleImage;

        public game()
        {
            InitializeComponent();
            InitializeGame();
            this.KeyDown += Form1_KeyDown;

            eatSound = new WindowsMediaPlayer();
            eatSound.URL = "D:\\C##\\maihuuphuoc_2122110106\\baitap\\Resources\\an.mp3";
            gameSound = new WindowsMediaPlayer();
            gameSound.URL = "D:\\C##\\maihuuphuoc_2122110106\\baitap\\Resources\\lum.mp3";

            snakeHeadImage = Image.FromFile("D:\\C##\\maihuuphuoc_2122110106\\baitap\\Resources\\ran.png");
            foodImage = Image.FromFile("D:\\C##\\maihuuphuoc_2122110106\\baitap\\Resources\\moi.png");
            obstacleImage = Image.FromFile("D:\\C##\\maihuuphuoc_2122110106\\baitap\\Resources\\bom.png");
        }

        private void InitializeGame()
        {
            gameTimer.Interval = 100;
            gameTimer.Tick += GameLoop;

            countdownTimer.Interval = 1000;
            countdownTimer.Tick += Countdown;

            flashTimer.Interval = 500; // Nhấp nháy mỗi nửa giây cho cấp độ 3
            flashTimer.Tick += ToggleFlash;

            StartGame();
        }

        private void StartGame()
        {
            snake.Clear();
            snake.Add(new Point(10, 10));
            GenerateFood();
            obstacles.Clear();
            score = 0;
            level = 1;
            timeRemaining = 15;

            direction = "right";
            gameTimer.Start();
            countdownTimer.Start();
            flashTimer.Stop(); // Đảm bảo nhấp nháy tắt ở cấp độ 1
            gamePanel.BackColor = Color.White; // Đặt màu nền ban đầu
            UpdateLabels();
        }

        private void GenerateFood()
        {
            Point newFood;
            do
            {
                int x = rand.Next(0, gamePanel.Width / cellSize);
                int y = rand.Next(0, gamePanel.Height / cellSize);
                newFood = new Point(x, y);
            } while (snake.Contains(newFood) || obstacles.Contains(newFood));

            food = newFood;
        }

        private void GenerateObstacles(int level)
        {
            obstacles.Clear();
            int obstacleCount = level; // Số lượng chướng ngại vật tăng theo cấp độ
            for (int i = 0; i < obstacleCount; i++)
            {
                Point obstacle;
                do
                {
                    int x = rand.Next(0, gamePanel.Width / cellSize);
                    int y = rand.Next(0, gamePanel.Height / cellSize);
                    obstacle = new Point(x, y);
                } while (snake.Contains(obstacle) || obstacle == food || obstacles.Contains(obstacle));

                obstacles.Add(obstacle);
            }
        }

        private void ToggleFlash(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            gamePanel.BackColor = isDarkMode ? Color.Black : Color.White;
            UpdateLabels(); 
        }

        private void GameLoop(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            gamePanel.Invalidate();
        }

        private void Countdown(object sender, EventArgs e)
        {
            timeRemaining--;
            UpdateLabels();
            if (timeRemaining <= 0)
            {
                GameOver();
            }
        }

        private void MoveSnake()
        {
            Point head = snake[0];
            Point newHead = head;

            if (direction == "up") newHead.Y--;
            else if (direction == "down") newHead.Y++;
            else if (direction == "left") newHead.X--;
            else if (direction == "right") newHead.X++;

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score+=5;
                timeRemaining += 5;
                eatSound.controls.play();
                GenerateFood();

                if (score % 5 == 0)
                {
                    level++;
                    gameTimer.Interval = Math.Max(20, gameTimer.Interval - 10);
                    GenerateObstacles(level);

                    // Bật hiệu ứng nhấp nháy cho cấp độ 3
                    if (level == 3)
                    {
                        flashTimer.Start();
                    }
                    else
                    {
                        flashTimer.Stop();
                        gamePanel.BackColor = Color.White; // Đặt lại nền cho các cấp độ thấp hơn
                    }
                }
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            scoreLabel.Text = $"Điểm: {score}";
            levelLabel.Text = $"Cấp độ: {level}";
            timeLabel.Text = $"Thời gian còn lại: {timeRemaining}s";
            scoreLabel.ForeColor = isDarkMode ? Color.Red : Color.Black;
            levelLabel.ForeColor = isDarkMode ? Color.Red : Color.Black;
            timeLabel.ForeColor = isDarkMode ? Color.Red : Color.Black;
        }

        private void CheckCollision()
        {
            Point head = snake[0];

            // Kiểm tra va chạm với tường
            if (head.X < 0 || head.Y < 0 || head.X >= gamePanel.Width / cellSize || head.Y >= gamePanel.Height / cellSize)
            {
                GameOver();
            }

            // Kiểm tra va chạm với thân rắn
            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    GameOver();
                }
            }

            // Kiểm tra va chạm với chướng ngại vật
            foreach (var obstacle in obstacles)
            {
                if (head == obstacle)
                {
                    GameOver();
                }
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            countdownTimer.Stop();
            flashTimer.Stop(); // Dừng nhấp nháy khi kết thúc trò chơi

            DialogResult result = MessageBox.Show($"Trò chơi kết thúc! Điểm cuối: {score}\nBạn có muốn thoát trò chơi?",
                                                    "Kết thúc trò chơi",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                StartGame();
            }
        }

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

        private Image RotateImage(Image img, float angle)
        {
            Bitmap bmp = new Bitmap(cellSize, cellSize);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                g.DrawImage(img, new Rectangle(0, 0, cellSize, cellSize));
            }
            return bmp;
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Vẽ đầu rắn với hình ảnh xoay dựa trên hướng di chuyển
            float angle = direction == "up" ? 0 : direction == "right" ? 90 : direction == "down" ? 180 : 270;
            Rectangle headRect = new Rectangle(snake[0].X * cellSize, snake[0].Y * cellSize, cellSize, cellSize);
            g.DrawImage(RotateImage(snakeHeadImage, angle), headRect);

            // Vẽ các phần thân của rắn
            for (int i = 1; i < snake.Count; i++)
            {
                Rectangle rect = new Rectangle(snake[i].X * cellSize, snake[i].Y * cellSize, cellSize, cellSize);
                g.FillEllipse(Brushes.Green, rect);
            }

            // Vẽ thức ăn
            Rectangle foodRect = new Rectangle(food.X * cellSize, food.Y * cellSize, cellSize, cellSize);
            g.DrawImage(foodImage, foodRect);

            // Vẽ các chướng ngại vật
            foreach (var obstacle in obstacles)
            {
                Rectangle obstacleRect = new Rectangle(obstacle.X * cellSize, obstacle.Y * cellSize, cellSize, cellSize);
                g.DrawImage(obstacleImage, obstacleRect);
            }
        }
    }
}