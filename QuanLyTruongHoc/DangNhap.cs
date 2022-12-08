
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTruongHoc
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            String dangnhap = tbtendangnhap.Text;
            String matkhau = tbmatkhau.Text;


            int kq = KiemTraDangNhap(dangnhap, matkhau);
            if(kq == 0)
            {
                QuanLyForm quanLyForm = new QuanLyForm();
                quanLyForm.Show();
            }
            else if(kq == 1)
            {
                QuanLyForm quanLyForm = new QuanLyForm();
                quanLyForm.Show();
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

    }
}