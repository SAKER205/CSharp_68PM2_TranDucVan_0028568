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

        private void btn_add_Click(object sender, EventArgs e)
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

        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DSSV.Rows.Count)
            {
                DataGridViewRow row = dgv_DSSV.Rows[e.RowIndex];

                txt_msv.Text = row.Cells["id"].Value?.ToString();
                txt_hoten.Text = row.Cells["hoten"].Value?.ToString();

                if (row.Cells["ngaysinh"].Value != null && DateTime.TryParse(row.Cells["ngaysinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    txt_ngaysinh.Value = ngaySinh;
                }
                else
                {
                    txt_ngaysinh.Value = DateTime.Now;
                }

                if (row.Cells["gioitinh"].Value != null)
                {
                    txt_gioitinh.Text = row.Cells["gioitinh"].Value.ToString();
                }
                else
                {
                    txt_gioitinh.SelectedIndex = -1;
                }

                if (row.Cells["malop"].Value != null)
                {
                    txt_lop.SelectedValue = row.Cells["malop"].Value.ToString();
                }
                else
                {
                    txt_lop.SelectedIndex = -1;
                }
                txt_msv.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_msv.Text.Trim()) || string.IsNullOrEmpty(txt_hoten.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn sinh viên và nhập thông tin cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txt_gioitinh.TabIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txt_lop.SelectedIndex == -1) 
            {
                MessageBox.Show("Vui lòng chọn Lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string msv = txt_msv.Text.Trim();
                tbl_sinhvien sv = db.tbl_sinhviens.SingleOrDefault(x => x.id == msv);

                if (sv != null)
                {
                    sv.hoten = txt_hoten.Text.Trim();
                    sv.gioitinh = txt_gioitinh.SelectedItem.ToString();
                    sv.ngaysinh = txt_ngaysinh.Value;
                    sv.malop = txt_lop.SelectedValue.ToString();
                    db.SubmitChanges();
                    LoadData();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã: " + msv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}