using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc
{
    public class QuanLyTaiKhoan
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

       public int ThemTaiKhoan(TaiKhoanDTO dTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_TaoTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@TenDangNhap", Value = dTO.Tendangnhap },
                   new SqlParameter { ParameterName = "@MatKhau", Value = dTO.Matkhau },
                   new SqlParameter { ParameterName = "@Loai", Value = dTO.Loai });
                return nRow;
            }
            catch(Exception ex)
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

        public int SuaTaiKhoan(TaiKhoanDTO dTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_SuaTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@ten", Value = dTO.Tendangnhap },
                   new SqlParameter { ParameterName = "@matkhau", Value = dTO.Matkhau },
                   new SqlParameter { ParameterName = "@loai", Value = dTO.Loai });
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

        public DataTable TimTaiKhoan()
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
