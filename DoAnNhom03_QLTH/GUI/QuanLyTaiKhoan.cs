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


namespace GUI
{
    public partial class QuanLyTaiKhoan : Form
    {
        public TaiKhoan rowSelected;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            QuanLyTaiKhoanBUS quanLyTaiKhoanBUS = new QuanLyTaiKhoanBUS();
            DataTable dt = quanLyTaiKhoanBUS.laytatcataikhoan();
            dgvDsTk.DataSource = dt;
        }

        public void ClearDataForm()
        {
            tbTendangnhap.Text = "";
            tbMatkhau.Text = "";
            cbLoai.SelectedIndex = 0;
        }

        public TaiKhoan getInForForm()
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            string tendangnhap = tbTendangnhap.Text;
            string matkhau = tbMatkhau.Text;
            int loai = Convert.ToInt32(cbLoai.SelectedItem.ToString());
            taiKhoan.TenDangNhap = tendangnhap;
            taiKhoan.MatKhau = matkhau;
            taiKhoan.Loai = loai;
            return taiKhoan;
        }

        private void dgvDSTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangnhap = tbTendangnhap.Text;
                string matKhau = tbMatkhau.Text;
                int loai = Convert.ToInt32(cbLoai.SelectedItem.ToString());

                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.TenDangNhap = tenDangnhap;
                taiKhoan.MatKhau = matKhau;
                taiKhoan.Loai = loai;
                QuanLyTaiKhoanDAO quanLyTaiKhoanAcess = new QuanLyTaiKhoanDAO();
                int kq = quanLyTaiKhoanAcess.ThemTaiKhoan(taiKhoan);
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

        private void dgvDsTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDsTk.RowCount)
            {
                rowSelected = new TaiKhoan();
                rowSelected.TenDangNhap = dgvDsTk.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.MatKhau = dgvDsTk.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.Loai = Convert.ToInt32(dgvDsTk.Rows[e.RowIndex].Cells[2].Value.ToString());

                tbTendangnhap.Text = dgvDsTk.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbMatkhau.Text = dgvDsTk.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLoai.SelectedItem = Convert.ToInt32(dgvDsTk.Rows[e.RowIndex].Cells[2].Value.ToString());

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan taiKhoan = getInForForm();
                QuanLyTaiKhoanBUS quanLyTaiKhoanBUS = new QuanLyTaiKhoanBUS();
                int kq = quanLyTaiKhoanBUS.SuaTaiKhoan(taiKhoan);
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
                QuanLyTaiKhoanBUS quanLyTaiKhoanBUS = new QuanLyTaiKhoanBUS();
                int kq = quanLyTaiKhoanBUS.XoaTaiKhoan(rowSelected.TenDangNhap);
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
