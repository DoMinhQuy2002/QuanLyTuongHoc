using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace GUI
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvDsMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loaddata()
        {
            QuanLyMonHocBUS quanLyMonHocBUS = new QuanLyMonHocBUS();
            DataTable dt = quanLyMonHocBUS.laytatcamonhoc();
            dgvDsMH.DataSource = dt;
        }

        public void ClearDataForm()
        {
            tbMaMH.Text = "";
            tbTenMH.Text = "";
            nudSoChi.TabIndex = 0;
        }

        public MonHoc getInForForm()
        {
            MonHoc monHoc = new MonHoc();
            string mamh = tbMaMH.Text;
            string tenmh = tbTenMH.Text;
            int sochi = Convert.ToInt32(nudSoChi.TabIndex.ToString());
            monHoc.MaMH = mamh;
            monHoc.TenMH = tenmh;
            monHoc.SoChi = sochi;
            return monHoc;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                string mamh = tbMaMH.Text;
                string tenmh = tbTenMH.Text;
                int sochi = Convert.ToInt32(nudSoChi.TabIndex.ToString());

                MonHoc monHoc = new MonHoc();
                monHoc.MaMH = mamh;
                monHoc.TenMH = tenmh;
                monHoc.SoChi = sochi;
                QuanLyMonHocBUS quanLyMonHocBUS = new QuanLyMonHocBUS();
                int kq = quanLyMonHocBUS.ThemMonHoc(monHoc);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                    ClearDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Taotaikhoan: " + ex.ToString());
            }
        }
    }
}
