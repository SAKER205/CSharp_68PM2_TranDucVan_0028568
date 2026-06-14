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
    public partial class UCQLLH : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int pageNumber = 1;
        int pageSize = 3;
        int totalPages = 1;

        public UCQLLH()
        {
            InitializeComponent();
        }

        private void UCQLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            db = new DataBaseDataContext();
            string keyword = txt_search.Text.Trim().ToLower();

            var query = db.tbl_lophocs.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => (x.id.ToString().Contains(keyword)) ||
                                         (x.malop != null && x.malop.ToLower().Contains(keyword)) ||
                                         (x.tenlop != null && x.tenlop.ToLower().Contains(keyword)) ||
                                         (x.ghichu != null && x.ghichu.ToLower().Contains(keyword)));
            }

            int totalRecords = query.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (totalPages < 1) totalPages = 1;
            if (pageNumber < 1) pageNumber = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;

            var dSLop = query.Skip((pageNumber - 1) * pageSize)
                             .Take(pageSize)
                             .Select(x => new {
                                 id = x.id,
                                 malop = x.malop,
                                 tenlop = x.tenlop,
                                 ghichu = x.ghichu
                             })
                             .ToList();
            dgv_DSLop.AutoGenerateColumns = true;

            dgv_DSLop.DataSource = dSLop;

            page_Number.Text = pageNumber.ToString();
            total_Page.Text = totalPages.ToString();
            total_Records.Text = totalRecords.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_malop.Text.Trim()) || string.IsNullOrEmpty(txt_tenlop.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                tbl_lophoc lh = new tbl_lophoc();
                lh.malop = txt_malop.Text.Trim();
                lh.tenlop = txt_tenlop.Text.Trim();
                lh.ghichu = txt_ghichu.Text.Trim();

                db.tbl_lophocs.InsertOnSubmit(lh);
                db.SubmitChanges();

                int totalRecords = db.tbl_lophocs.Count();
                pageNumber = (int)Math.Ceiling((double)totalRecords / pageSize);

                LoadData();
                ClearForm();
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu (Có thể do trùng Mã lớp): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text.Trim()) || string.IsNullOrEmpty(txt_malop.Text.Trim()) || string.IsNullOrEmpty(txt_tenlop.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn lớp học từ bảng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idLop = Convert.ToInt32(txt_id.Text.Trim());
                tbl_lophoc lh = db.tbl_lophocs.SingleOrDefault(x => x.id == idLop);

                if (lh != null)
                {
                    lh.malop = txt_malop.Text.Trim();
                    lh.tenlop = txt_tenlop.Text.Trim();
                    lh.ghichu = txt_ghichu.Text.Trim();

                    db.SubmitChanges();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int idLop = Convert.ToInt32(txt_id.Text.Trim());

                    bool coSinhVien = db.tbl_sinhviens.Any(x => x.id_lop == idLop);

                    if (coSinhVien)
                    {
                        MessageBox.Show("Không thể xóa lớp học này vì đang có sinh viên đang học!", "Cảnh báo an toàn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    tbl_lophoc lh = db.tbl_lophocs.SingleOrDefault(x => x.id == idLop);

                    if (lh != null)
                    {
                        db.tbl_lophocs.DeleteOnSubmit(lh);
                        db.SubmitChanges();

                        string keyword = txt_search.Text.Trim().ToLower();
                        int totalRecords = db.tbl_lophocs.Count(x => x.malop.ToLower().Contains(keyword) || x.tenlop.ToLower().Contains(keyword));
                        totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                        if (pageNumber > totalPages) pageNumber = totalPages;

                        LoadData();
                        ClearForm();
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_DSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DSLop.Rows.Count)
            {
                DataGridViewRow row = dgv_DSLop.Rows[e.RowIndex];

                txt_id.Text = row.Cells["id"].Value?.ToString();
                txt_malop.Text = row.Cells["malop"].Value?.ToString();
                txt_tenlop.Text = row.Cells["tenlop"].Value?.ToString();
                txt_ghichu.Text = row.Cells["ghichu"].Value?.ToString();

                txt_id.Enabled = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_id.Text = "";
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            txt_ghichu.Text = "";
            txt_id.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            LoadData();
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
        private void btn_viewStudents_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ danh sách trước khi xem sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txt_id.Text.Trim(), out int idLop))
            {
                string tenLop = txt_tenlop.Text.Trim();

                FrmDanhSachSV frm = new FrmDanhSachSV(idLop, tenLop);
                frm.ShowDialog();
            }
        }
    }
}