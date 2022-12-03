using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTruongHoc
{
    public partial class Taotaikhoan : Form
    {
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

                String query1 = "INSERT INTO TaiKhoan VALUES(@TenDangNhap, @MatKhau, @Loai)";
                Provider provider = new Provider();
                provider.Connect();
                int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@TenDangNhap", Value = tenDangnhap},
                    new SqlParameter { ParameterName = "@MatKhau", Value = matKhau},
                    new SqlParameter { ParameterName = "@Loai", Value = loai});
                if(nRow > 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Taotaikhoan: " + ex.ToString());
            }

        }
    }
}
