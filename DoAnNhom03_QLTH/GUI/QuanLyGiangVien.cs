using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace GUI
{
    public partial class QuanLyGiangVien : Form
    {
        public GiangVien rowSelected;
        public QuanLyGiangVien()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            QuanLyGiangVienBUS quanLyGiangVienBUS = new QuanLyGiangVienBUS();
            DataTable dt = quanLyGiangVienBUS.laytatcagiangvien();
            dgvDsGv.DataSource = dt;
        }

        public void ClearDataForm()
        {
            tbMaGv.Text = "";
            tbTenGv.Text = "";
            tbNgaySinh.Text = "";
            tbGioiTinh.Text = "";
            tbDienThoai.Text = "";
            tbMaGvQL.Text = "";
        }

        public GiangVien getInForForm()
        {
            GiangVien giangVien = new GiangVien();
            string maGv = tbMaGv.Text;
            string tenGv = tbTenGv.Text;
            string ngaySinh = tbNgaySinh.Text;
            string gioiTinh = tbGioiTinh.Text;
            string dienThoai = tbDienThoai.Text;
            string maGvQL = tbMaGvQL.Text;
            giangVien.MaGv = maGv;
            giangVien.TenGv = tenGv;
            giangVien.NgaySinh = ngaySinh;
            giangVien.GioiTinh = gioiTinh;
            giangVien.DienThoai = dienThoai;
            giangVien.MaGvQuanli = maGvQL;
            return giangVien;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                string maGv = tbMaGv.Text;
                string tenGv = tbTenGv.Text;
                string ngaySinh = tbNgaySinh.Text;
                string gioiTinh = tbGioiTinh.Text;
                string dienThoai = tbDienThoai.Text;
                string maGvQL = tbMaGvQL.Text;

                GiangVien giangVien = new GiangVien();
                giangVien.MaGv = maGv;
                giangVien.TenGv = tenGv;
                giangVien.NgaySinh = ngaySinh;
                giangVien.GioiTinh = gioiTinh;
                giangVien.DienThoai = dienThoai;
                giangVien.MaGvQuanli = maGvQL;
                QuanLyGiangVienBUS quanLyGiangVienBUS = new QuanLyGiangVienBUS();
                int kq = quanLyGiangVienBUS.ThemGiangVien(giangVien);
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

        private void dgvDsGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDsGv.RowCount)
            {
                rowSelected = new GiangVien();
                rowSelected.MaGv = dgvDsGv.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.TenGv = dgvDsGv.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.NgaySinh = dgvDsGv.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowSelected.GioiTinh = dgvDsGv.Rows[e.RowIndex].Cells[3].Value.ToString();
                rowSelected.DienThoai = dgvDsGv.Rows[e.RowIndex].Cells[4].Value.ToString();
                rowSelected.MaGvQuanli = dgvDsGv.Rows[e.RowIndex].Cells[5].Value.ToString();

                tbMaGv.Text = dgvDsGv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenGv.Text = dgvDsGv.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbNgaySinh.Text = dgvDsGv.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGioiTinh.Text = dgvDsGv.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDienThoai.Text = dgvDsGv.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbMaGvQL.Text = dgvDsGv.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien giangVien = getInForForm();
                QuanLyGiangVienBUS quanLyGiangVienBUS = new QuanLyGiangVienBUS();
                int kq = quanLyGiangVienBUS.SuaGiangVien(giangVien);
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
                QuanLyGiangVienBUS quanLyGiangVienBUS = new QuanLyGiangVienBUS();
                int kq = quanLyGiangVienBUS.XoaGiangVien(rowSelected.MaGv);
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
