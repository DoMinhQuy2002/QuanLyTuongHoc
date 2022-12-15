using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyGiangVienBUS
    {
        public DataTable laytatcagiangvien()
        {
            try
            {
                QuanLyGiangVienDAO quanLyGiangVienDAO = new QuanLyGiangVienDAO();
                return quanLyGiangVienDAO.laytatcagiangvien();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ThemGiangVien(GiangVien giangVien)
        {
            try
            {
                QuanLyGiangVienDAO quanLyGiangVienDAO = new QuanLyGiangVienDAO();
                return quanLyGiangVienDAO.ThemGiangVien(giangVien);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int XoaGiangVien(String maGv)
        {
            try
            {
                QuanLyGiangVienDAO quanLyGiangVienDAO = new QuanLyGiangVienDAO();
                return quanLyGiangVienDAO.XoaGiangVien(maGv);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaGiangVien(GiangVien giangVien)
        {
            try
            {
                QuanLyGiangVienDAO quanLyGiangVienDAO = new QuanLyGiangVienDAO();
                return quanLyGiangVienDAO.SuaGiangVien(giangVien);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable TimGiangVien(string maGv)
        {
            try
            {
                QuanLyGiangVienDAO quanLyGiangVienDAO = new QuanLyGiangVienDAO();
                return quanLyGiangVienDAO.TimGiangVien(maGv);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
