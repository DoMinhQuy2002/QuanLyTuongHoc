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
using DAO;
using DTO;
using BUS;

namespace GUI
{
    public partial class QuanLyKetQuaSinhVien : Form
    {
        public KetQuaSinhVien rowSelected;
        public QuanLyKetQuaSinhVien()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            QuanLyKetQuaSinhVienBUS quanLyKetQuaSinhVienBUS = new QuanLyKetQuaSinhVienBUS();
            DataTable dt = quanLyKetQuaSinhVienBUS.laytatcaketquasinhvien();
            dgvDsKqSv.DataSource = dt;
        }

        public void ClearDataForm()
        {
            tbMaKQSV.Text = "";
            tbMaMH.Text = "";
            tbLanthi.Text = "";
            tbDiem.Text = "";
        }

        public KetQuaSinhVien getInForForm()
        {
            KetQuaSinhVien ketQuaSinhVien = new KetQuaSinhVien();
            string maKq = tbMaKQSV.Text;
            string maMh = tbMaMH.Text;
            string lanThi = tbLanthi.Text;
            string diem = tbDiem.Text;
            ketQuaSinhVien.MaKqSv = maKq;
            ketQuaSinhVien.MaMH = maMh;
            ketQuaSinhVien.LanThi = lanThi;
            ketQuaSinhVien.DiemTb = diem;
            return ketQuaSinhVien;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                string maKq = tbMaKQSV.Text;
                string maMh = tbMaMH.Text;
                string lanThi = tbLanthi.Text;
                string diem = tbDiem.Text;

                KetQuaSinhVien ketQuaSinhVien = new KetQuaSinhVien();
                ketQuaSinhVien.MaKqSv = maKq;
                ketQuaSinhVien.MaMH = maMh;
                ketQuaSinhVien.LanThi = lanThi;
                ketQuaSinhVien.DiemTb = diem;
                QuanLyKetQuaSinhVienBUS quanLyKetQuaSinhVienBUS = new QuanLyKetQuaSinhVienBUS();
                int kq = quanLyKetQuaSinhVienBUS.ThemKetQuaSinhVien(ketQuaSinhVien);
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

        private void dgvDsKqSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDsKqSv.RowCount)
            {
                rowSelected = new KetQuaSinhVien();
                rowSelected.MaKqSv = dgvDsKqSv.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.MaMH = dgvDsKqSv.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.LanThi = dgvDsKqSv.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowSelected.DiemTb = dgvDsKqSv.Rows[e.RowIndex].Cells[3].Value.ToString();

                tbMaKQSV.Text = dgvDsKqSv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbMaMH.Text = dgvDsKqSv.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbLanthi.Text = dgvDsKqSv.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDiem.Text = dgvDsKqSv.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void QuanLyKetQuaSinhVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KetQuaSinhVien ketQuaSinhVien = getInForForm();
                QuanLyKetQuaSinhVienBUS quanLyKetQuaSinhVienBUS = new QuanLyKetQuaSinhVienBUS();
                int kq = quanLyKetQuaSinhVienBUS.SuaKetQuaSinhVien(ketQuaSinhVien);
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
                QuanLyKetQuaSinhVienBUS quanLyKetQuaSinhVienBUS = new QuanLyKetQuaSinhVienBUS();
                int kq = quanLyKetQuaSinhVienBUS.XoaKetQuaSinhVien(rowSelected.MaKqSv);
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
