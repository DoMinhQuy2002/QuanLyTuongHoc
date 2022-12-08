using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc
{
    public class TaiKhoanDTO
    {
        private string _tendangnhap;
        private string _matkhau;
        private int _loai;

        public string Tendangnhap { get => _tendangnhap; set => _tendangnhap = value; }
        public string Matkhau { get => _matkhau; set => _matkhau = value; }
        public int Loai { get => _loai; set => _loai = value; }
    }
}
