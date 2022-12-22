namespace GUI
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
            this.btnQLGV = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQLKQ = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLGV
            // 
            this.btnQLGV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.ForeColor = System.Drawing.Color.White;
            this.btnQLGV.Location = new System.Drawing.Point(325, 115);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(156, 64);
            this.btnQLGV.TabIndex = 2;
            this.btnQLGV.Text = "Quản lý giảng viên";
            this.btnQLGV.UseVisualStyleBackColor = false;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.ForeColor = System.Drawing.Color.White;
            this.btnQLSV.Location = new System.Drawing.Point(538, 115);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(156, 64);
            this.btnQLSV.TabIndex = 3;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLKQ
            // 
            this.btnQLKQ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQLKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKQ.ForeColor = System.Drawing.Color.White;
            this.btnQLKQ.Location = new System.Drawing.Point(432, 266);
            this.btnQLKQ.Name = "btnQLKQ";
            this.btnQLKQ.Size = new System.Drawing.Size(156, 64);
            this.btnQLKQ.TabIndex = 4;
            this.btnQLKQ.Text = "Quản lý kết quả";
            this.btnQLKQ.UseVisualStyleBackColor = false;
            this.btnQLKQ.Click += new System.EventHandler(this.btnQLKQ_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQLMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMH.ForeColor = System.Drawing.Color.White;
            this.btnQLMH.Location = new System.Drawing.Point(211, 266);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(156, 64);
            this.btnQLMH.TabIndex = 5;
            this.btnQLMH.Text = "Quản lý môn học";
            this.btnQLMH.UseVisualStyleBackColor = false;
            this.btnQLMH.Click += new System.EventHandler(this.btnQLMH_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTK.ForeColor = System.Drawing.Color.White;
            this.btnQLTK.Location = new System.Drawing.Point(112, 115);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(156, 64);
            this.btnQLTK.TabIndex = 6;
            this.btnQLTK.Text = "Quản lý tài khoản";
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLTK);
            this.Controls.Add(this.btnQLMH);
            this.Controls.Add(this.btnQLKQ);
            this.Controls.Add(this.btnQLSV);
            this.Controls.Add(this.btnQLGV);
            this.Name = "QuanLyForm";
            this.Text = "QuanLyForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQLGV;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnQLKQ;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Button btnQLTK;
    }
}