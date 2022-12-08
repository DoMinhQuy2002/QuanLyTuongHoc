namespace QuanLyTruongHoc
{
    partial class QuanLyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyForm));
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyMonHoc = new System.Windows.Forms.Button();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnQuanLyGiangVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(69, 68);
            this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(279, 124);
            this.btnQuanLyTaiKhoan.TabIndex = 0;
            this.btnQuanLyTaiKhoan.Text = "Quản Lí Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyMonHoc
            // 
            this.btnQuanLyMonHoc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyMonHoc.Location = new System.Drawing.Point(458, 68);
            this.btnQuanLyMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            this.btnQuanLyMonHoc.Size = new System.Drawing.Size(279, 124);
            this.btnQuanLyMonHoc.TabIndex = 2;
            this.btnQuanLyMonHoc.Text = "Quản Lý Môn Học";
            this.btnQuanLyMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(458, 257);
            this.btnQuanLySinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(279, 124);
            this.btnQuanLySinhVien.TabIndex = 3;
            this.btnQuanLySinhVien.Text = "Quản Lý Sinh Viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyGiangVien
            // 
            this.btnQuanLyGiangVien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyGiangVien.Location = new System.Drawing.Point(69, 257);
            this.btnQuanLyGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuanLyGiangVien.Name = "btnQuanLyGiangVien";
            this.btnQuanLyGiangVien.Size = new System.Drawing.Size(279, 124);
            this.btnQuanLyGiangVien.TabIndex = 4;
            this.btnQuanLyGiangVien.Text = "Quản Lý Giảng Viên";
            this.btnQuanLyGiangVien.UseVisualStyleBackColor = true;
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 456);
            this.Controls.Add(this.btnQuanLyGiangVien);
            this.Controls.Add(this.btnQuanLySinhVien);
            this.Controls.Add(this.btnQuanLyMonHoc);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyForm";
            this.Text = "QuanLyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnQuanLyTaiKhoan;
        private Button btnQuanLyMonHoc;
        private Button btnQuanLySinhVien;
        private Button btnQuanLyGiangVien;
    }
}