using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        private string _maHV;
        private string _tenHV;
        private string _ngaySinh;
        private string _tinhTrang;
        private string _maLop;

        public string MaHV { get => _maHV; set => _maHV = value; }
        public string TenHV { get => _tenHV; set => _tenHV = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
        public string MaLop { get => _maLop; set => _maLop = value; }
    }
}
