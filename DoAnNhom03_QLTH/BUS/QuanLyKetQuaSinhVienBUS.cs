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
    public class QuanLyKetQuaSinhVienBUS
    {
        public DataTable laytatcaketquasinhvien()
        {
            try
            {
                QuanLyKetQuaSinhVienDAO quanLyKetQuaSinhVienDAO = new QuanLyKetQuaSinhVienDAO();
                return quanLyKetQuaSinhVienDAO.laytatcaketquasinhvien();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ThemKetQuaSinhVien(KetQuaSinhVien ketQuaSinhVien)
        {
            try
            {
                QuanLyKetQuaSinhVienDAO quanLyKetQuaSinhVienDAO = new QuanLyKetQuaSinhVienDAO();
                return quanLyKetQuaSinhVienDAO.ThemKetQuaSinhVien(ketQuaSinhVien);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int XoaKetQuaSinhVien(String maKq)
        {
            try
            {
                QuanLyKetQuaSinhVienDAO quanLyKetQuaSinhVienDAO = new QuanLyKetQuaSinhVienDAO();
                return quanLyKetQuaSinhVienDAO.XoaKetQuaSinhVien(maKq);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaKetQuaSinhVien(KetQuaSinhVien ketQuaSinhVien)
        {
            try
            {
                QuanLyKetQuaSinhVienDAO quanLyKetQuaSinhVienDAO = new QuanLyKetQuaSinhVienDAO();
                return quanLyKetQuaSinhVienDAO.SuaKetQuaSinhVien(ketQuaSinhVien);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable TimKetQuaSinhVien(string maKq)
        {
            try
            {
                QuanLyKetQuaSinhVienDAO quanLyKetQuaSinhVienDAO = new QuanLyKetQuaSinhVienDAO();
                return quanLyKetQuaSinhVienDAO.TimKetQuaSinhVien(maKq);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
