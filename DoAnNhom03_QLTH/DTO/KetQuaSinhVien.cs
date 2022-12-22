using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQuaSinhVien
    {
        private string _maKqSv;
        private string _maMH;
        private string _lanThi;
        private string _diemTb;

        public string MaKqSv { get => _maKqSv; set => _maKqSv = value; }
        public string MaMH { get => _maMH; set => _maMH = value; }
        public string LanThi { get => _lanThi; set => _lanThi = value; }
        public string DiemTb { get => _diemTb; set => _diemTb = value; }
    }
}
