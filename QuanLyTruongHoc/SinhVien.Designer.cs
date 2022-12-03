namespace QuanLyTruongHoc
{
    partial class SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.btntkb = new System.Windows.Forms.Button();
            this.btnbd = new System.Windows.Forms.Button();
            this.btnlt = new System.Windows.Forms.Button();
            this.btnhp = new System.Windows.Forms.Button();
            this.btndkmh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(480, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // btntkb
            // 
            this.btntkb.BackColor = System.Drawing.Color.Ivory;
            this.btntkb.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntkb.ForeColor = System.Drawing.Color.Orange;
            this.btntkb.Location = new System.Drawing.Point(556, 285);
            this.btntkb.Name = "btntkb";
            this.btntkb.Size = new System.Drawing.Size(324, 54);
            this.btntkb.TabIndex = 2;
            this.btntkb.Text = "Thời khoá biểu";
            this.btntkb.UseVisualStyleBackColor = false;
            // 
            // btnbd
            // 
            this.btnbd.BackColor = System.Drawing.Color.Ivory;
            this.btnbd.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbd.ForeColor = System.Drawing.Color.Orange;
            this.btnbd.Location = new System.Drawing.Point(556, 383);
            this.btnbd.Name = "btnbd";
            this.btnbd.Size = new System.Drawing.Size(324, 54);
            this.btnbd.TabIndex = 3;
            this.btnbd.Text = "Bảng điểm";
            this.btnbd.UseVisualStyleBackColor = false;
            this.btnbd.Click += new System.EventHandler(this.btnbd_Click);
            // 
            // btnlt
            // 
            this.btnlt.BackColor = System.Drawing.Color.Ivory;
            this.btnlt.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlt.ForeColor = System.Drawing.Color.Orange;
            this.btnlt.Location = new System.Drawing.Point(556, 485);
            this.btnlt.Name = "btnlt";
            this.btnlt.Size = new System.Drawing.Size(324, 54);
            this.btnlt.TabIndex = 4;
            this.btnlt.Text = "Lịch thi";
            this.btnlt.UseVisualStyleBackColor = false;
            // 
            // btnhp
            // 
            this.btnhp.BackColor = System.Drawing.Color.Ivory;
            this.btnhp.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnhp.ForeColor = System.Drawing.Color.Orange;
            this.btnhp.Location = new System.Drawing.Point(556, 590);
            this.btnhp.Name = "btnhp";
            this.btnhp.Size = new System.Drawing.Size(324, 55);
            this.btnhp.TabIndex = 5;
            this.btnhp.Text = "Học phí";
            this.btnhp.UseVisualStyleBackColor = false;
            // 
            // btndkmh
            // 
            this.btndkmh.BackColor = System.Drawing.Color.Ivory;
            this.btndkmh.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndkmh.ForeColor = System.Drawing.Color.Orange;
            this.btndkmh.Location = new System.Drawing.Point(556, 180);
            this.btndkmh.Name = "btndkmh";
            this.btndkmh.Size = new System.Drawing.Size(324, 54);
            this.btndkmh.TabIndex = 6;
            this.btndkmh.Text = "Đăng ký môn học";
            this.btndkmh.UseVisualStyleBackColor = false;
            this.btndkmh.Click += new System.EventHandler(this.btndkmh_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 773);
            this.Controls.Add(this.btndkmh);
            this.Controls.Add(this.btnhp);
            this.Controls.Add(this.btnlt);
            this.Controls.Add(this.btnbd);
            this.Controls.Add(this.btntkb);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btntkb;
        private Button btnbd;
        private Button btnlt;
        private Button btnhp;
        private Button btndkmh;
    }
}