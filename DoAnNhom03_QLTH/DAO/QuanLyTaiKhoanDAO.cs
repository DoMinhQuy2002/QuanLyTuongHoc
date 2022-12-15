using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class QuanLyTaiKhoanDAO
    {

        public DataTable laytatcataikhoan()
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM TaiKhoan";
                provider.Connect();
                dt = provider.Select(CommandType.Text, query);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.Connect();
            }
            return null;
        }

        public int ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_TaoTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@TenDangNhap", Value = taiKhoan.TenDangNhap },
                   new SqlParameter { ParameterName = "@MatKhau", Value = taiKhoan.MatKhau },
                   new SqlParameter { ParameterName = "@Loai", Value = taiKhoan.Loai });
                return nRow;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.DisConect();
            }
            return nRow;

        }

        public int XoaTaiKhoan(String TenDangNhap)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_XoaTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@ten", Value = TenDangNhap });
                return nRow;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.DisConect();
            }
            return nRow;
        }

        public int SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_SuaTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@ten", Value = taiKhoan.TenDangNhap },
                   new SqlParameter { ParameterName = "@matkhau", Value = taiKhoan.MatKhau },
                   new SqlParameter { ParameterName = "@loai", Value = taiKhoan.Loai });
                return nRow;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.DisConect();
            }
            return nRow;
        }

        public DataTable TimTaiKhoan(string ten)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "sp_TimTaiKhoan";
                provider.Connect();
                dt = provider.Select(CommandType.Text, query);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.Connect();
            }
            return null;
        }
    }
}
