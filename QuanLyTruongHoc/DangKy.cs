using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            DangKySinhVien dangKySinhVien = new DangKySinhVien();
            dangKySinhVien.Show();
        }

        private void btngiangvien_Click(object sender, EventArgs e)
        {
            DangKyGiangVien dangKyGiangVien = new DangKyGiangVien();
            dangKyGiangVien.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Taotaikhoan taotaikhoan = new Taotaikhoan();
            taotaikhoan.Show();
        }
    }
}
