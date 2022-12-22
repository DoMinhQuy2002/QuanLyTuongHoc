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
    public class QuanLySinhVienDAO
    {
        public DataTable laytatcasinhvien()
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM HocVien";
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

        public int ThemSinhVien(SinhVien sinhVien)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_TaoSV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maHv", Value = sinhVien.MaHV },
                   new SqlParameter { ParameterName = "@tenHv", Value = sinhVien.TenHV },
                   new SqlParameter { ParameterName = "@ngaySinh", Value = sinhVien.NgaySinh },
                   new SqlParameter { ParameterName = "@tinhTrang", Value = sinhVien.TinhTrang },
                   new SqlParameter { ParameterName = "@maLop", Value = sinhVien.MaLop });
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

        public int XoaSinhVien(String maHv)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_XoaSV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maHv", Value = maHv });
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

        public int SuaSinhVien(SinhVien sinhVien)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_SuaSV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                  new SqlParameter { ParameterName = "@maHv", Value = sinhVien.MaHV },
                   new SqlParameter { ParameterName = "@tenHv", Value = sinhVien.TenHV },
                   new SqlParameter { ParameterName = "@ngaySinh", Value = sinhVien.NgaySinh },
                   new SqlParameter { ParameterName = "@tinhTrang", Value = sinhVien.TinhTrang },
                   new SqlParameter { ParameterName = "@maLop", Value = sinhVien.MaLop });
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

        public DataTable TimSinhVien(string maHv)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "sp_TimHV";
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
