using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyGiangVienDAO
    {
        public DataTable laytatcagiangvien()
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM GiaoVien";
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

        public int ThemGiangVien(GiangVien giangVien)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_TaoGV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@magv", Value = giangVien.MaGv },
                   new SqlParameter { ParameterName = "@tengv", Value = giangVien.TenGv },
                   new SqlParameter { ParameterName = "@ngaysinh", Value = giangVien.NgaySinh },
                   new SqlParameter { ParameterName = "@gioitinh", Value = giangVien.GioiTinh },
                   new SqlParameter { ParameterName = "@dienthoai", Value = giangVien.DienThoai },
                   new SqlParameter { ParameterName = "@magvquanli", Value = giangVien.MaGvQuanli });
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

        public int XoaGiangVien(String maGv)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_XoaGV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@magv", Value = maGv });
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

        public int SuaGiangVien(GiangVien giangVien)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_SuaGV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@magv", Value = giangVien.MaGv },
                   new SqlParameter { ParameterName = "@tengv", Value = giangVien.TenGv },
                   new SqlParameter { ParameterName = "@ngaysinh", Value = giangVien.NgaySinh },
                   new SqlParameter { ParameterName = "@gioitinh", Value = giangVien.GioiTinh },
                   new SqlParameter { ParameterName = "@dienthoai", Value = giangVien.DienThoai },
                   new SqlParameter { ParameterName = "@magvquanli", Value = giangVien.MaGvQuanli });
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

        public DataTable TimGiangVien(string maGv)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "sp_TimGV";
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
