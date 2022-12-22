using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QuanLySinhVienBUS
    {
        public DataTable laytatcasinhvien()
        {
            try
            {
                QuanLySinhVienDAO quanLySinhVienDAO = new QuanLySinhVienDAO();
                return quanLySinhVienDAO.laytatcasinhvien();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ThemSinhVien(SinhVien sinhVien)
        {
            try
            {
                QuanLySinhVienDAO quanLySinhVienDAO = new QuanLySinhVienDAO();
                return quanLySinhVienDAO.ThemSinhVien(sinhVien);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int XoaSinhVien(String maHv)
        {
            try
            {
                QuanLySinhVienDAO quanLySinhVienDAO = new QuanLySinhVienDAO();
                return quanLySinhVienDAO.XoaSinhVien(maHv);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaSinhVien(SinhVien sinhVien)
        {
            try
            {
                QuanLySinhVienDAO quanLySinhVienDAO = new QuanLySinhVienDAO();
                return quanLySinhVienDAO.SuaSinhVien(sinhVien);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable TimSinhVien(string maHv)
        {
            try
            {
                QuanLySinhVienDAO quanLySinhVienDAO = new QuanLySinhVienDAO();
                return quanLySinhVienDAO.TimSinhVien(maHv);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
