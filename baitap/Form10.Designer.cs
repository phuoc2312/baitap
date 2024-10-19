namespace baitap
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChoosesImage = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmloyeeName = new System.Windows.Forms.TextBox();
            this.picEmployeePhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(63, 37);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(86, 16);
            this.lbEmployeeID.TabIndex = 0;
            this.lbEmployeeID.Text = "Ma nhan vien";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(63, 93);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(102, 16);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "Teen Nhan vien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anh 3x4";
            // 
            // btnChoosesImage
            // 
            this.btnChoosesImage.Location = new System.Drawing.Point(444, 154);
            this.btnChoosesImage.Name = "btnChoosesImage";
            this.btnChoosesImage.Size = new System.Drawing.Size(106, 40);
            this.btnChoosesImage.TabIndex = 3;
            this.btnChoosesImage.Text = "Chon anh";
            this.btnChoosesImage.UseVisualStyleBackColor = true;
            this.btnChoosesImage.Click += new System.EventHandler(this.btnChoosesImage_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(252, 37);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 4;
            // 
            // txtEmloyeeName
            // 
            this.txtEmloyeeName.Location = new System.Drawing.Point(252, 93);
            this.txtEmloyeeName.Name = "txtEmloyeeName";
            this.txtEmloyeeName.Size = new System.Drawing.Size(267, 22);
            this.txtEmloyeeName.TabIndex = 5;
            // 
            // picEmployeePhoto
            // 
            this.picEmployeePhoto.Location = new System.Drawing.Point(252, 143);
            this.picEmployeePhoto.Name = "picEmployeePhoto";
            this.picEmployeePhoto.Size = new System.Drawing.Size(119, 137);
            this.picEmployeePhoto.TabIndex = 6;
            this.picEmployeePhoto.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picEmployeePhoto);
            this.Controls.Add(this.txtEmloyeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnChoosesImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbEmployeeID);
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChoosesImage;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmloyeeName;
        private System.Windows.Forms.PictureBox picEmployeePhoto;
    }
}