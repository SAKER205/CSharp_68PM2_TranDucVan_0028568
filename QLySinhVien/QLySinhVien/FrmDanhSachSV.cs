using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySinhVien
{
    public partial class FrmDanhSachSV : Form
    {
        private int idLop;
        private string tenLop;

        public FrmDanhSachSV(int idLopSelected, string tenLopSelected)
        {
            InitializeComponent();
            this.idLop = idLopSelected;
            this.tenLop = tenLopSelected;
        }

        private void FrmDanhSachSV_Load(object sender, EventArgs e)
        {
            this.Text = "Danh Sách Sinh Viên Của Lớp " + tenLop;

            try
            {
                var dbSV = new DataBaseDataContext();
                var dSSV = dbSV.tbl_sinhviens
                               .Where(x => x.id_lop == idLop)
                               .Select(x => new {
                                   id = x.id,
                                   hoten = x.hoten,
                                   gioitinh = x.gioitinh,
                                   ngaysinh = x.ngaysinh
                               })
                               .ToList();

                dgv_DSSV.DataSource = dSSV;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}