using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QuanLyMonHocBUS
    {
        public DataTable laytatcamonhoc()
        {
            try
            {
                QuanLyMonHocDAO quanLyMonHocDAO = new QuanLyMonHocDAO();
                return quanLyMonHocDAO.laytatcamonhoc();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ThemMonHoc(MonHoc monHoc)
        {
            try
            {
                QuanLyMonHocDAO quanLyMonHocDAO = new QuanLyMonHocDAO();
                return quanLyMonHocDAO.ThemMonHoc(monHoc);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int XoaMonHoc(String MaMh)
        {
            try
            {
                QuanLyMonHocDAO quanLyMonHocDAO = new QuanLyMonHocDAO();
                return quanLyMonHocDAO.XoaMonHoc(MaMh);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaMonHoc(MonHoc monHoc)
        {
            try
            {
                QuanLyMonHocDAO quanLyMonHocDAO = new QuanLyMonHocDAO();
                return quanLyMonHocDAO.SuaMonHoc(monHoc);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable TimMonHoc(string maMh)
        {
            try
            {
                QuanLyMonHocDAO quanLyMonHocDAO = new QuanLyMonHocDAO();
                return quanLyMonHocDAO.TimMonHoc(maMh);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
