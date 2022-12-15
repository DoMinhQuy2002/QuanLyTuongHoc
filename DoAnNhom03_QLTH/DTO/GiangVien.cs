using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        private string _maGv;
        private string _tenGv;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _dienThoai;
        private string _maGvQuanli;

        public string MaGv { get => _maGv; set => _maGv = value; }
        public string TenGv { get => _tenGv; set => _tenGv = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string MaGvQuanli { get => _maGvQuanli; set => _maGvQuanli = value; }
    }
}
