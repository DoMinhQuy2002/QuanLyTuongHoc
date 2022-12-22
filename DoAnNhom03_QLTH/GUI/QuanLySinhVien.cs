using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
using BUS;

namespace GUI
{
    public partial class QuanLySinhVien : Form
    {
        public SinhVien rowSelected;
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            QuanLySinhVienBUS quanLySinhVienBUS = new QuanLySinhVienBUS();
            DataTable dt = quanLySinhVienBUS.laytatcasinhvien();
            dgvDsSv.DataSource = dt;
        }

        public void ClearDataForm()
        {
            tbMahv.Text = "";
            tbTenhv.Text = "";
            tbNgaysinh.Text = "";
            tbTinhtrang.Text = "";
            tbMalop.Text = "";
        }

        public SinhVien getInForForm()
        {
            SinhVien sinhVien = new SinhVien();
            string maHv = tbMahv.Text;
            string tenHv = tbTenhv.Text;
            string ngaySinh = tbNgaysinh.Text;
            string tinhTrang = tbTinhtrang.Text;
            string maLop = tbMalop.Text;
            sinhVien.MaHV = maHv;
            sinhVien.TenHV = tenHv;
            sinhVien.NgaySinh = ngaySinh;
            sinhVien.TinhTrang = tinhTrang;
            sinhVien.MaLop = maLop;
            return sinhVien;
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvDsSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDsSv.RowCount)
            {
                rowSelected = new SinhVien();
                rowSelected.MaHV = dgvDsSv.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.TenHV = dgvDsSv.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.NgaySinh = dgvDsSv.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowSelected.TinhTrang = dgvDsSv.Rows[e.RowIndex].Cells[3].Value.ToString();
                rowSelected.MaLop = dgvDsSv.Rows[e.RowIndex].Cells[4].Value.ToString();

                tbMahv.Text = dgvDsSv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenhv.Text = dgvDsSv.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbNgaysinh.Text = dgvDsSv.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbTinhtrang.Text = dgvDsSv.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbMalop.Text = dgvDsSv.Rows[e.RowIndex].Cells[4].Value.ToString();

            }

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                string maHv = tbMahv.Text;
                string tenHv = tbTenhv.Text;
                string ngaySinh = tbNgaysinh.Text;
                string tinhTrang = tbTinhtrang.Text;
                string maLop = tbMalop.Text;

                SinhVien sinhVien = new SinhVien();
                sinhVien.MaHV = maHv;
                sinhVien.TenHV = tenHv;
                sinhVien.NgaySinh = ngaySinh;
                sinhVien.TinhTrang = tinhTrang;
                sinhVien.MaLop = maLop;
                QuanLySinhVienBUS quanLySinhVienBUS = new QuanLySinhVienBUS();
                int kq = quanLySinhVienBUS.ThemSinhVien(sinhVien);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                    ClearDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Taotaikhoan: " + ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sinhVien = getInForForm();
                QuanLySinhVienBUS quanLySinhVienBUS = new QuanLySinhVienBUS();
                int kq = quanLySinhVienBUS.SuaSinhVien(sinhVien);
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loaddata();
                    ClearDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLySinhVienBUS quanLySinhVienBUS = new QuanLySinhVienBUS();
                int kq = quanLySinhVienBUS.XoaSinhVien(rowSelected.MaHV);
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công");
                    loaddata();
                    ClearDataForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
