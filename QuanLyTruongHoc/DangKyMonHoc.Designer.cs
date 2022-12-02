namespace QuanLyTruongHoc
{
    partial class DangKyMonHoc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sochi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sochi02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndangky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lldangky = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký môn học";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoc,
            this.monhoc,
            this.sochi});
            this.dataGridView1.Location = new System.Drawing.Point(126, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(428, 58);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addtenmonhoc,
            this.addmonhoc,
            this.sochi02,
            this.btndangky});
            this.dataGridView2.Location = new System.Drawing.Point(86, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(553, 61);
            this.dataGridView2.TabIndex = 8;
            // 
            // mamonhoc
            // 
            this.mamonhoc.HeaderText = "Mã môn học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.Width = 125;
            // 
            // monhoc
            // 
            this.monhoc.HeaderText = "Môn học";
            this.monhoc.MinimumWidth = 6;
            this.monhoc.Name = "monhoc";
            this.monhoc.Width = 125;
            // 
            // sochi
            // 
            this.sochi.HeaderText = "Số chỉ";
            this.sochi.MinimumWidth = 6;
            this.sochi.Name = "sochi";
            this.sochi.Width = 125;
            // 
            // addtenmonhoc
            // 
            this.addtenmonhoc.HeaderText = "Tên môn học";
            this.addtenmonhoc.MinimumWidth = 6;
            this.addtenmonhoc.Name = "addtenmonhoc";
            this.addtenmonhoc.Width = 125;
            // 
            // addmonhoc
            // 
            this.addmonhoc.HeaderText = "Môn học";
            this.addmonhoc.MinimumWidth = 6;
            this.addmonhoc.Name = "addmonhoc";
            this.addmonhoc.Width = 125;
            // 
            // sochi02
            // 
            this.sochi02.HeaderText = "Số chỉ";
            this.sochi02.MinimumWidth = 6;
            this.sochi02.Name = "sochi02";
            this.sochi02.Width = 125;
            // 
            // btndangky
            // 
            this.btndangky.HeaderText = "Đăng ký";
            this.btndangky.MinimumWidth = 6;
            this.btndangky.Name = "btndangky";
            this.btndangky.Width = 125;
            // 
            // lldangky
            // 
            this.lldangky.AutoSize = true;
            this.lldangky.Location = new System.Drawing.Point(531, 168);
            this.lldangky.Name = "lldangky";
            this.lldangky.Size = new System.Drawing.Size(63, 20);
            this.lldangky.TabIndex = 9;
            this.lldangky.TabStop = true;
            this.lldangky.Text = "Đăng ký";
            // 
            // DangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 479);
            this.Controls.Add(this.lldangky);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DangKyMonHoc";
            this.Text = "DangKyMonHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn mamonhoc;
        private DataGridViewTextBoxColumn monhoc;
        private DataGridViewTextBoxColumn sochi;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn addtenmonhoc;
        private DataGridViewTextBoxColumn addmonhoc;
        private DataGridViewTextBoxColumn sochi02;
        private DataGridViewTextBoxColumn btndangky;
        private LinkLabel lldangky;
    }
}