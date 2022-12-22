namespace GUI
{
    partial class DanhSachSinhVien
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
            this.dgvDsSv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDsKq = new System.Windows.Forms.DataGridView();
            this.MaKQHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsSv
            // 
            this.dgvDsSv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsSv.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsSv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocVien,
            this.TenHocVien,
            this.TinhTrang,
            this.MaLop});
            this.dgvDsSv.Location = new System.Drawing.Point(64, 172);
            this.dgvDsSv.Name = "dgvDsSv";
            this.dgvDsSv.RowHeadersWidth = 51;
            this.dgvDsSv.RowTemplate.Height = 24;
            this.dgvDsSv.Size = new System.Drawing.Size(556, 364);
            this.dgvDsSv.TabIndex = 0;
            this.dgvDsSv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsSv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(368, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // MaHocVien
            // 
            this.MaHocVien.DataPropertyName = "MaHocVien";
            this.MaHocVien.HeaderText = "Mã học viên";
            this.MaHocVien.MinimumWidth = 6;
            this.MaHocVien.Name = "MaHocVien";
            // 
            // TenHocVien
            // 
            this.TenHocVien.DataPropertyName = "TenHocVien";
            this.TenHocVien.HeaderText = "Tên học viên";
            this.TenHocVien.MinimumWidth = 6;
            this.TenHocVien.Name = "TenHocVien";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            // 
            // dgvDsKq
            // 
            this.dgvDsKq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsKq.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsKq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsKq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKQHV,
            this.MaMonHoc,
            this.LanThi,
            this.DiemTB});
            this.dgvDsKq.Location = new System.Drawing.Point(655, 172);
            this.dgvDsKq.Name = "dgvDsKq";
            this.dgvDsKq.RowHeadersWidth = 51;
            this.dgvDsKq.RowTemplate.Height = 24;
            this.dgvDsKq.Size = new System.Drawing.Size(439, 364);
            this.dgvDsKq.TabIndex = 2;
            this.dgvDsKq.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsKq_CellClick);
            // 
            // MaKQHV
            // 
            this.MaKQHV.DataPropertyName = "MaKQHV";
            this.MaKQHV.HeaderText = "Mã kết quả sinh viên";
            this.MaKQHV.MinimumWidth = 6;
            this.MaKQHV.Name = "MaKQHV";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã môn học";
            this.MaMonHoc.MinimumWidth = 6;
            this.MaMonHoc.Name = "MaMonHoc";
            // 
            // LanThi
            // 
            this.LanThi.DataPropertyName = "LanThi";
            this.LanThi.HeaderText = "Lần thi";
            this.LanThi.MinimumWidth = 6;
            this.LanThi.Name = "LanThi";
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            // 
            // DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 603);
            this.Controls.Add(this.dgvDsKq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDsSv);
            this.Name = "DanhSachSinhVien";
            this.Text = "DanhSachSinhVien";
            this.Load += new System.EventHandler(this.DanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsKq;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKQHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}