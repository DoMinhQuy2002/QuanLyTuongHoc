using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QuanLyKetQuaSinhVienDAO
    {
        public DataTable laytatcaketquasinhvien()
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM KetQuaSinhVien";
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

        public int ThemKetQuaSinhVien(KetQuaSinhVien ketQuaSinhVien)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_TaoKQSV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maKq", Value = ketQuaSinhVien.MaKqSv },
                   new SqlParameter { ParameterName = "@maMh", Value = ketQuaSinhVien.MaMH },
                   new SqlParameter { ParameterName = "@lanThi", Value = ketQuaSinhVien.LanThi },
                   new SqlParameter { ParameterName = "@diemTB", Value = ketQuaSinhVien.DiemTb });
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

        public int XoaKetQuaSinhVien(String maKq)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_XoaKQSV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maKq", Value = maKq });
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

        public int SuaKetQuaSinhVien(KetQuaSinhVien ketQuaSinhVien)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_SuaKQSV";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maKq", Value = ketQuaSinhVien.MaKqSv },
                   new SqlParameter { ParameterName = "@maMh", Value = ketQuaSinhVien.MaMH },
                   new SqlParameter { ParameterName = "@lanThi", Value = ketQuaSinhVien.LanThi },
                   new SqlParameter { ParameterName = "@diemTB", Value = ketQuaSinhVien.DiemTb });
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

        public DataTable TimKetQuaSinhVien(string maGv)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "sp_TimKQSV";
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
