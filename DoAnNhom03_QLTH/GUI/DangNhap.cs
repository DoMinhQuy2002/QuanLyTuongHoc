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
using BUS;
using System.Data.SqlClient;
using DAO;

namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDNhap_Click(object sender, EventArgs e)
        {

            String dangnhap = tbDNhap.Text;
            String matkhau = tbMKhau.Text;


            int kq = KiemTraDangNhap(dangnhap, matkhau);
            if (kq == 0)
            {
                QuanLyForm quanLyForm = new QuanLyForm();
                quanLyForm.Show();
            }
            else if (kq == 1)
            {
                DanhSachGiangVien danhSachGiangVien = new DanhSachGiangVien();
                danhSachGiangVien.Show();
            }
            else if(kq == 2)
            {
                DanhSachSinhVien danhSachSinhVien = new DanhSachSinhVien();
                danhSachSinhVien.Show();
            }


        }

        private int KiemTraDangNhap(string dangnhap, string matkhau)
        {

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
                MessageBox.Show("Form1: " + ex.ToString());
            }
            return -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
