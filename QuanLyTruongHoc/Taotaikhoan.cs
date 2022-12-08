using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTruongHoc
{
    public partial class Taotaikhoan : Form
    {
        public TaiKhoanDTO rowSelected;

        public Taotaikhoan()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangnhap = tbtenDangnhap.Text;
                string matKhau = tbmatKhau.Text;
                int loai = Convert.ToInt32(cbbloai.SelectedItem.ToString());

                TaiKhoanDTO dTO = new TaiKhoanDTO();
                dTO.Tendangnhap = tenDangnhap;
                dTO.Matkhau = matKhau;
                dTO.Loai = loai;
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                int kq = quanLyTaiKhoan.ThemTaiKhoan(dTO);
                if(kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                    ClearDataForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Taotaikhoan: " + ex.ToString());
            }

        }

        private void taotaikhoan_load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            QuanLyTaiKhoan quanlytaikhoan = new QuanLyTaiKhoan();
            DataTable dt = quanlytaikhoan.laytatcataikhoan();
            dgvDSTK.DataSource = dt;
        }

        public void ClearDataForm()
        {
            tbtenDangnhap.Text = "";
            tbmatKhau.Text = "";
            cbbloai.SelectedIndex = 0;
        }

        public TaiKhoanDTO getInForForm()
        {
            TaiKhoanDTO dTO = new TaiKhoanDTO();
            string tendangnhap = tbtenDangnhap.Text;
            string matkhau = tbtenDangnhap.Text;
            int loai = Convert.ToInt32(cbbloai.SelectedItem.ToString());
            return dTO;
        }
        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSTK.RowCount)
            {
                rowSelected = new TaiKhoanDTO();
                rowSelected.Tendangnhap = dgvDSTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.Matkhau = dgvDSTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.Loai = Convert.ToInt32(dgvDSTK.Rows[e.RowIndex].Cells[2].Value.ToString());

                tbtenDangnhap.Text = dgvDSTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbmatKhau.Text = dgvDSTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbloai.SelectedItem = Convert.ToInt32(dgvDSTK.Rows[e.RowIndex].Cells[2].Value.ToString());

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                int kq = quanLyTaiKhoan.XoaTaiKhoan(rowSelected.Tendangnhap);
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công");
                    loaddata();
                    ClearDataForm();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        public void getInFor()
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO dTO = getInForForm();
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                int kq = quanLyTaiKhoan.SuaTaiKhoan(dTO);
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
    }
}
