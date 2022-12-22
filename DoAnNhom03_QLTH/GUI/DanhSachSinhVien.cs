using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            QuanLySinhVienBUS quanLySinhVienBUS = new QuanLySinhVienBUS();
            DataTable dt1 = quanLySinhVienBUS.laytatcasinhvien();
            dgvDsSv.DataSource = dt1;

            QuanLyKetQuaSinhVienBUS quanLyKetQuaSinhVienBUS = new QuanLyKetQuaSinhVienBUS();
            DataTable dt2 = quanLyKetQuaSinhVienBUS.laytatcaketquasinhvien();
            dgvDsKq.DataSource = dt2;
        }

        private void dgvDsSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDsKq_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
