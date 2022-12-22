using DTO;
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
    public class QuanLyMonHocDAO
    {
        public DataTable laytatcamonhoc()
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM MonHoc";
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

        public int ThemMonHoc(MonHoc monHoc)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_TaoMH";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maMH", Value = monHoc.MaMH },
                   new SqlParameter { ParameterName = "@tenMH", Value = monHoc.TenMH },
                   new SqlParameter { ParameterName = "@soChi", Value = monHoc.SoChi });
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

        public int XoaMonHoc(String MaMh)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_XoaMH";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                   new SqlParameter { ParameterName = "@maMH", Value = MaMh });
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

        public int SuaMonHoc(MonHoc monHoc)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query = "sp_SuaMH";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query,
                  new SqlParameter { ParameterName = "@maMH", Value = monHoc.MaMH },
                   new SqlParameter { ParameterName = "@tenMH", Value = monHoc.TenMH },
                   new SqlParameter { ParameterName = "@soChi", Value = monHoc.SoChi });
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

        public DataTable TimMonHoc(string maMh)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                String query = "sp_TimMH";
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
