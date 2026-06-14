using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySinhVien
{
    public partial class UCQLSV : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int pageNumber = 1;
        int pageSize = 3;
        int totalPages = 1;

        public UCQLSV()
        {
            InitializeComponent();
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
            LoadComboBoxGioiTinh();
            LoadData();
        }

        public void LoadData()
        {
            db = new DataBaseDataContext();

            string keyword = txt_search.Text.Trim().ToLower();

            var query = db.tbl_sinhviens.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => (x.id != null && x.id.ToLower().Contains(keyword)) ||
                                         (x.hoten != null && x.hoten.ToLower().Contains(keyword)) ||
                                         (x.tbl_lophoc.tenlop != null && x.tbl_lophoc.tenlop.ToLower().Contains(keyword)));
            }

            int totalRecords = query.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (totalPages < 1) totalPages = 1;
            if (pageNumber < 1) pageNumber = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;

            var dSSV = query.Skip((pageNumber - 1) * pageSize)
                            .Take(pageSize)
                            .Select(x => new {
                                id = x.id,
                                hoten = x.hoten,
                                gioitinh = x.gioitinh,
                                ngaysinh = x.ngaysinh,
                                malop = x.tbl_lophoc.tenlop,
                                IDLop = x.id_lop
                            })
                            .ToList();

            dgv_DSSV.DataSource = dSSV;

            page_Number.Text = pageNumber.ToString();
            total_Page.Text = totalPages.ToString();
            total_Records.Text = totalRecords.ToString();
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
            txt_lop.ValueMember = "id";
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

            if (txt_lop.SelectedValue == null || txt_lop.SelectedIndex == -1)
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
                sv.id_lop = Convert.ToInt32(txt_lop.SelectedValue);

                db.tbl_sinhviens.InsertOnSubmit(sv);
                db.SubmitChanges();

                int totalRecords = db.tbl_sinhviens.Count();
                pageNumber = (int)Math.Ceiling((double)totalRecords / pageSize);

                LoadData();
                ClearForm();
                MessageBox.Show("Thêm sinh viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if (row.Cells["IDLop"].Value != null && int.TryParse(row.Cells["IDLop"].Value.ToString(), out int idLop))
                {
                    txt_lop.SelectedValue = idLop;
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
            if (string.IsNullOrEmpty(txt_msv.Text.Trim()) || string.IsNullOrEmpty(txt_hoten.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn sinh viên và nhập thông tin cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_gioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_lop.SelectedValue == null || txt_lop.SelectedIndex == -1)
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
                    sv.id_lop = Convert.ToInt32(txt_lop.SelectedValue);

                    db.SubmitChanges();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã: " + msv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_msv.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string maSV = txt_msv.Text.Trim();
                    tbl_sinhvien sv = db.tbl_sinhviens.SingleOrDefault(x => x.id == maSV);

                    if (sv != null)
                    {
                        db.tbl_sinhviens.DeleteOnSubmit(sv);
                        db.SubmitChanges();

                        string keyword = txt_search.Text.Trim().ToLower();
                        int totalRecords = db.tbl_sinhviens.Count(x => x.id.ToLower().Contains(keyword) || x.hoten.ToLower().Contains(keyword));
                        totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                        if (pageNumber > totalPages) pageNumber = totalPages;

                        LoadData();
                        ClearForm();
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            LoadData();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                LoadData();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (pageNumber < totalPages)
            {
                pageNumber++;
                LoadData();
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            pageNumber = totalPages;
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            LoadData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_msv.Text = "";
            txt_hoten.Text = "";
            txt_gioitinh.SelectedIndex = -1;
            txt_lop.SelectedIndex = -1;
            txt_ngaysinh.Value = DateTime.Now;
            txt_msv.Enabled = true;
        }
    }
}