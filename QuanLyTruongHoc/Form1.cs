
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTruongHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            String dangnhap = tbtendangnhap.Text;
            String matkhau = tbmatkhau.Text;
            int loai = Convert.ToInt32(cbbLoai.SelectedItem.ToString());

            int kq = KiemTraDangNhap(dangnhap, matkhau);
            if(kq == 0 && loai == 0)
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else if(kq == 0 && loai == 1)
            {
                GiangVien giangVien = new GiangVien();
                giangVien.Show();
            }
            else
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.Show();
            }
        }

        private int KiemTraDangNhap(string dangnhap, string matkhau) {

            try
            {
                string query1 = "SELECT * FROM TaiKhoan " + 
                    " WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                Provider provider = new Provider();
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, query1,
                    new SqlParameter { ParameterName = "@TenDangNhap", Value = dangnhap },
                    new SqlParameter { ParameterName = "@MatKhau", Value = matkhau });

                if (dt != null && dt.Rows.Count == 0)
                {
                    return -1;
                }    

                DataRow row = dt.Rows[0];
                return (int)row["Loai"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Form1: "+ex.ToString());
            }
            return -1;
        }

        private void lldangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Taotaikhoan taotaikhoan = new Taotaikhoan();
            taotaikhoan.Show();
        }
    }
}