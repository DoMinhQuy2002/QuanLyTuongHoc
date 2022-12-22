using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        private string _maMH;
        private string _tenMH;
        private int _soChi;

        public string MaMH { get => _maMH; set => _maMH = value; }
        public string TenMH { get => _tenMH; set => _tenMH = value; }
        public int SoChi { get => _soChi; set => _soChi = value; }
    }
}
