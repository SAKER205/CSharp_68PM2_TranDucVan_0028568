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
    public partial class UCQLSV : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public UCQLSV()
        {
            InitializeComponent();
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxGioiTinh();
            LoadComboBoxLop();
        }

        public void LoadData()
        {
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList();
            dgv_DSSV.DataSource = dSSV;
        }

        public void LoadComboBoxGioiTinh()
        {
            txt_gioitinh.Items.Clear();
            txt_gioitinh.Items.Add("Nam");
            txt_gioitinh.Items.Add("Nữ");
            txt_gioitinh.SelectedIndex = -1;
        }

        public void LoadComboBoxLop()
        {
            List<tbl_lophoc> dSLop = db.tbl_lophocs.ToList();
            txt_lop.DataSource = dSLop;
            txt_lop.DisplayMember = "tenlop";
            txt_lop.ValueMember = "malop";
            txt_lop.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_msv.Text.Trim()) || string.IsNullOrEmpty(txt_hoten.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_gioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_lop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                tbl_sinhvien sv = new tbl_sinhvien();
                sv.id = txt_msv.Text.Trim();
                sv.hoten = txt_hoten.Text.Trim();
                sv.gioitinh = txt_gioitinh.SelectedItem.ToString();
                sv.ngaysinh = txt_ngaysinh.Value;
                sv.malop = txt_lop.SelectedValue.ToString();

                db.tbl_sinhviens.InsertOnSubmit(sv);
                db.SubmitChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu (Có thể do trùng mã sinh viên): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}