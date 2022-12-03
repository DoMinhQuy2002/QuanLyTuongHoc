namespace QuanLyTruongHoc
{
    partial class DangKy
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
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnsinhvien = new System.Windows.Forms.Button();
            this.btngiangvien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadmin.ForeColor = System.Drawing.Color.Orange;
            this.btnadmin.Location = new System.Drawing.Point(94, 282);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(169, 68);
            this.btnadmin.TabIndex = 7;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnsinhvien
            // 
            this.btnsinhvien.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsinhvien.ForeColor = System.Drawing.Color.Orange;
            this.btnsinhvien.Location = new System.Drawing.Point(523, 282);
            this.btnsinhvien.Name = "btnsinhvien";
            this.btnsinhvien.Size = new System.Drawing.Size(184, 68);
            this.btnsinhvien.TabIndex = 6;
            this.btnsinhvien.Text = "Sinh Viên";
            this.btnsinhvien.UseVisualStyleBackColor = true;
            this.btnsinhvien.Click += new System.EventHandler(this.btnsinhvien_Click);
            // 
            // btngiangvien
            // 
            this.btngiangvien.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btngiangvien.ForeColor = System.Drawing.Color.Orange;
            this.btngiangvien.Location = new System.Drawing.Point(296, 282);
            this.btngiangvien.Name = "btngiangvien";
            this.btngiangvien.Size = new System.Drawing.Size(199, 68);
            this.btngiangvien.TabIndex = 5;
            this.btngiangvien.Text = "Giảng Viên";
            this.btngiangvien.UseVisualStyleBackColor = true;
            this.btngiangvien.Click += new System.EventHandler(this.btngiangvien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(150, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bạn muốn đăng ký ";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnsinhvien);
            this.Controls.Add(this.btngiangvien);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnadmin;
        private Button btnsinhvien;
        private Button btngiangvien;
        private Label label1;
    }
}