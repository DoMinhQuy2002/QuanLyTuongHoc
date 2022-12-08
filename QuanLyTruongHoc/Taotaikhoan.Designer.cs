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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // tbtenDangnhap
            // 
            this.tbtenDangnhap.Location = new System.Drawing.Point(205, 79);
            this.tbtenDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbtenDangnhap.Name = "tbtenDangnhap";
            this.tbtenDangnhap.Size = new System.Drawing.Size(251, 23);
            this.tbtenDangnhap.TabIndex = 4;
            // 
            // tbmatKhau
            // 
            this.tbmatKhau.Location = new System.Drawing.Point(205, 125);
            this.tbmatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmatKhau.Name = "tbmatKhau";
            this.tbmatKhau.Size = new System.Drawing.Size(251, 23);
            this.tbmatKhau.TabIndex = 6;
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbbloai.Location = new System.Drawing.Point(205, 176);
            this.cbbloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(46, 23);
            this.cbbloai.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(168, 260);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(82, 30);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 260);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "0: Admin, 1: Giảng Viên, 2: Sinh Viên";
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.AllowUserToAddRows = false;
            this.dgvDSTK.AllowUserToDeleteRows = false;
            this.dgvDSTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTK.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.MatKhau,
            this.Loai});
            this.dgvDSTK.Location = new System.Drawing.Point(545, 79);
            this.dgvDSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.ReadOnly = true;
            this.dgvDSTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDSTK.RowHeadersWidth = 51;
            this.dgvDSTK.RowTemplate.Height = 29;
            this.dgvDSTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTK.Size = new System.Drawing.Size(519, 250);
            this.dgvDSTK.TabIndex = 12;
            this.dgvDSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTK_CellClick);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "TenDangNhap";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loai";
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(545, 354);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(645, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Taotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 395);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvDSTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbloai);
            this.Controls.Add(this.tbmatKhau);
            this.Controls.Add(this.tbtenDangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Taotaikhoan";
            this.Text = "Taotaikhoan";
            this.Load += new System.EventHandler(this.taotaikhoan_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
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
        private Label label4;
        private DataGridView dgvDSTK;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn Loai;
        private Button btnSua;
        private Button btnXoa;
    }
}