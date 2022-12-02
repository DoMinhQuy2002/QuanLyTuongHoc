namespace QuanLyTruongHoc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.tbtendangnhap = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.llquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.lldangky = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(222, 325);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 29);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(367, 325);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 29);
            this.btnhuy.TabIndex = 6;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // tbtendangnhap
            // 
            this.tbtendangnhap.Location = new System.Drawing.Point(222, 124);
            this.tbtendangnhap.Name = "tbtendangnhap";
            this.tbtendangnhap.Size = new System.Drawing.Size(335, 27);
            this.tbtendangnhap.TabIndex = 7;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(222, 182);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(335, 27);
            this.tbmatkhau.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên đăng nhập";
            // 
            // llquenmatkhau
            // 
            this.llquenmatkhau.AutoSize = true;
            this.llquenmatkhau.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.llquenmatkhau.Location = new System.Drawing.Point(181, 392);
            this.llquenmatkhau.Name = "llquenmatkhau";
            this.llquenmatkhau.Size = new System.Drawing.Size(109, 20);
            this.llquenmatkhau.TabIndex = 10;
            this.llquenmatkhau.TabStop = true;
            this.llquenmatkhau.Text = "Quên mật khẩu";
            // 
            // lldangky
            // 
            this.lldangky.AutoSize = true;
            this.lldangky.Location = new System.Drawing.Point(434, 392);
            this.lldangky.Name = "lldangky";
            this.lldangky.Size = new System.Drawing.Size(63, 20);
            this.lldangky.TabIndex = 11;
            this.lldangky.TabStop = true;
            this.lldangky.Text = "Đăng ký";
            this.lldangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldangky_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "0: Admin, 1: Giảng Viên, 2: Sinh Viên";
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbbLoai.Location = new System.Drawing.Point(222, 243);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(51, 28);
            this.cbbLoai.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lldangky);
            this.Controls.Add(this.llquenmatkhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtendangnhap);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnok;
        private Button btnhuy;
        private TextBox tbtendangnhap;
        private TextBox tbmatkhau;
        private Label label6;
        private LinkLabel llquenmatkhau;
        private LinkLabel lldangky;
        private Label label4;
        private Label label5;
        private ComboBox cbbLoai;
    }
}