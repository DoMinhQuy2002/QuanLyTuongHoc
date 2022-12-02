namespace QuanLyTruongHoc
{
    partial class Taotaikhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtenDangnhap = new System.Windows.Forms.TextBox();
            this.tbmatKhau = new System.Windows.Forms.TextBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // tbtenDangnhap
            // 
            this.tbtenDangnhap.Location = new System.Drawing.Point(234, 105);
            this.tbtenDangnhap.Name = "tbtenDangnhap";
            this.tbtenDangnhap.Size = new System.Drawing.Size(286, 27);
            this.tbtenDangnhap.TabIndex = 4;
            // 
            // tbmatKhau
            // 
            this.tbmatKhau.Location = new System.Drawing.Point(234, 167);
            this.tbmatKhau.Name = "tbmatKhau";
            this.tbmatKhau.Size = new System.Drawing.Size(286, 27);
            this.tbmatKhau.TabIndex = 6;
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbbloai.Location = new System.Drawing.Point(234, 235);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(52, 28);
            this.cbbloai.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(192, 347);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(94, 40);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Taotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbloai);
            this.Controls.Add(this.tbmatKhau);
            this.Controls.Add(this.tbtenDangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Taotaikhoan";
            this.Text = "Taotaikhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbtenDangnhap;
        private TextBox tbmatKhau;
        private ComboBox cbbloai;
        private Label label5;
        private Button btnTao;
        private Button button2;
    }
}