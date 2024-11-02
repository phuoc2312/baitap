namespace SnakeGame
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true nếu cần phải giải phóng các tài nguyên được sử dụng.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Phương thức cần thiết để hỗ trợ Designer - không thay đổi nội dung
        /// bằng trình chỉnh sửa mã.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamePanel = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.gamePanel.Location = new System.Drawing.Point(12, 38);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(748, 599);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(50, 10);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 25);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score: 0";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(153, 9);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(81, 25);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "Level: 0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(252, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(110, 25);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "TimeLeft: 0";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 666);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gamePanel);
            this.Name = "game";
            this.Text = "Snake Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}
