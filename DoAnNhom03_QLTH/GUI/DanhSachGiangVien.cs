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
    public partial class DanhSachGiangVien : Form
    {
        public DanhSachGiangVien()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            QuanLyGiangVienBUS quanLyGiangVienBUS = new QuanLyGiangVienBUS();
            DataTable dt = quanLyGiangVienBUS.laytatcagiangvien();
            dgvDsGv.DataSource = dt;
        }

        private void dgvDsGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }
    }
}
