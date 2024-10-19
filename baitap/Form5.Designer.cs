namespace baitap
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwis
        /// e, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kq = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.cham = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(12, 12);
            this.kq.Multiline = true;
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(319, 59);
            this.kq.TabIndex = 0;
            this.kq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(12, 88);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(64, 59);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button1_Click);
            // 
            // cong
            // 
            this.cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cong.Location = new System.Drawing.Point(12, 153);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(64, 59);
            this.cong.TabIndex = 1;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.button2_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(96, 88);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(64, 59);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button3_Click);
            // 
            // nhan
            // 
            this.nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhan.Location = new System.Drawing.Point(96, 153);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(64, 59);
            this.nhan.TabIndex = 1;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.button4_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(183, 88);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(64, 59);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button5_Click);
            // 
            // cham
            // 
            this.cham.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cham.Location = new System.Drawing.Point(183, 153);
            this.cham.Name = "cham";
            this.cham.Size = new System.Drawing.Size(64, 59);
            this.cham.TabIndex = 1;
            this.cham.Text = ".";
            this.cham.UseVisualStyleBackColor = true;
            this.cham.Click += new System.EventHandler(this.button6_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(267, 88);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(64, 59);
            this.b3.TabIndex = 1;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button7_Click);
            // 
            // bang
            // 
            this.bang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bang.Location = new System.Drawing.Point(267, 153);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(64, 59);
            this.bang.TabIndex = 1;
            this.bang.Text = "=";
            this.bang.UseVisualStyleBackColor = true;
            this.bang.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 233);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.cham);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.kq);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button cham;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bang;
    }
}