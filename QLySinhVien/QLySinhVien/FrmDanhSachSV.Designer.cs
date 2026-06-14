namespace QLySinhVien
{
    partial class FrmDanhSachSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AllowUserToAddRows = false;
            this.dgv_DSSV.AllowUserToDeleteRows = false;
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSSV.Location = new System.Drawing.Point(0, 0);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.ReadOnly = true;
            this.dgv_DSSV.RowHeadersVisible = false;
            this.dgv_DSSV.RowHeadersWidth = 51;
            this.dgv_DSSV.RowTemplate.Height = 24;
            this.dgv_DSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSV.Size = new System.Drawing.Size(800, 450);
            this.dgv_DSSV.TabIndex = 0;
            // 
            // FrmDanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_DSSV);
            this.Name = "FrmDanhSachSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sinh Viên Của Lớp";
            this.Load += new System.EventHandler(this.FrmDanhSachSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_DSSV;
    }
}