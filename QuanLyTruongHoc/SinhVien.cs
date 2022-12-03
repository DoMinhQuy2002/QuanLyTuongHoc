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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void btndkmh_Click(object sender, EventArgs e)
        {
            SinhVien_DangKyMonHoc sinhVien_DangKyMonHoc = new SinhVien_DangKyMonHoc();
            sinhVien_DangKyMonHoc.Show();
        }

        private void btnbd_Click(object sender, EventArgs e)
        {
            SinhVien_BangDiem sinhVien_BangDiem = new SinhVien_BangDiem();
            sinhVien_BangDiem.Show();
        }
    }
}
