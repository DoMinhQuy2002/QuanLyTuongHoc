using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class QuanLyTaiKhoanBUS
    {
        public DataTable laytatcataikhoan()
        {
            try
            {
                QuanLyTaiKhoanDAO quanLyTaiKhoanDAO = new QuanLyTaiKhoanDAO();
                return quanLyTaiKhoanDAO.laytatcataikhoan();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                QuanLyTaiKhoanDAO quanLyTaiKhoanDAO = new QuanLyTaiKhoanDAO();
                return quanLyTaiKhoanDAO.ThemTaiKhoan(taiKhoan);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int XoaTaiKhoan(String TenDangNhap)
        {
            try
            {
                QuanLyTaiKhoanDAO quanLyTaiKhoanDAO = new QuanLyTaiKhoanDAO();
                return quanLyTaiKhoanDAO.XoaTaiKhoan(TenDangNhap);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                QuanLyTaiKhoanDAO quanLyTaiKhoanDAO = new QuanLyTaiKhoanDAO();
                return quanLyTaiKhoanDAO.SuaTaiKhoan(taiKhoan);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable TimTaiKhoan(string ten)
        {
            try
            {
                QuanLyTaiKhoanDAO quanLyTaiKhoanDAO = new QuanLyTaiKhoanDAO();
                return quanLyTaiKhoanDAO.TimTaiKhoan(ten);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
