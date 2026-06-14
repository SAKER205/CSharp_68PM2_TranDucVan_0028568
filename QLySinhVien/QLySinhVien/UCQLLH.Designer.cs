namespace QLySinhVien
{
    partial class UCQLLH
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_DSLop = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_viewStudents = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.total_Records = new System.Windows.Forms.Label();
            this.total_Page = new System.Windows.Forms.Label();
            this.page_Number = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DSLop
            // 
            this.dgv_DSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSLop.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Malop,
            this.Tenlop,
            this.Ghichu});
            this.dgv_DSLop.Location = new System.Drawing.Point(369, 79);
            this.dgv_DSLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSLop.Name = "dgv_DSLop";
            this.dgv_DSLop.RowHeadersVisible = false;
            this.dgv_DSLop.RowHeadersWidth = 62;
            this.dgv_DSLop.RowTemplate.Height = 28;
            this.dgv_DSLop.Size = new System.Drawing.Size(664, 434);
            this.dgv_DSLop.TabIndex = 29;
            this.dgv_DSLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSLop_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Malop
            // 
            this.Malop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Malop.DataPropertyName = "malop";
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.MinimumWidth = 8;
            this.Malop.Name = "Malop";
            // 
            // Tenlop
            // 
            this.Tenlop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenlop.DataPropertyName = "tenlop";
            this.Tenlop.HeaderText = "Tên lớp";
            this.Tenlop.MinimumWidth = 8;
            this.Tenlop.Name = "Tenlop";
            // 
            // Ghichu
            // 
            this.Ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ghichu.DataPropertyName = "ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.MinimumWidth = 8;
            this.Ghichu.Name = "Ghichu";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(794, 28);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 46);
            this.button6.TabIndex = 28;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(369, 40);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(401, 22);
            this.txt_search.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tìm kiếm (Mã ID/ Mã lớp/ Tên lớp)";
            // 
            // btn_viewStudents
            // 
            this.btn_viewStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_viewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewStudents.Location = new System.Drawing.Point(12, 537);
            this.btn_viewStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_viewStudents.Name = "btn_viewStudents";
            this.btn_viewStudents.Size = new System.Drawing.Size(332, 46);
            this.btn_viewStudents.TabIndex = 25;
            this.btn_viewStudents.Text = "Xem danh sách sinh viên";
            this.btn_viewStudents.UseVisualStyleBackColor = false;
            this.btn_viewStudents.Click += new System.EventHandler(this.btn_viewStudents_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(187, 467);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 46);
            this.button4.TabIndex = 24;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thông tin lớp học";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(12, 467);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(157, 46);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(187, 401);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(157, 46);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(12, 401);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(157, 46);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ghichu);
            this.panel1.Controls.Add(this.txt_tenlop);
            this.panel1.Controls.Add(this.txt_malop);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 361);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã ID:";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(30, 288);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(264, 22);
            this.txt_ghichu.TabIndex = 3;
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Location = new System.Drawing.Point(30, 215);
            this.txt_tenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(264, 22);
            this.txt_tenlop.TabIndex = 2;
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(30, 136);
            this.txt_malop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(264, 22);
            this.txt_malop.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(30, 59);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(264, 22);
            this.txt_id.TabIndex = 0;
            // 
            // total_Records
            // 
            this.total_Records.AutoSize = true;
            this.total_Records.Location = new System.Drawing.Point(629, 562);
            this.total_Records.Name = "total_Records";
            this.total_Records.Size = new System.Drawing.Size(14, 16);
            this.total_Records.TabIndex = 55;
            this.total_Records.Text = "3";
            // 
            // total_Page
            // 
            this.total_Page.AutoSize = true;
            this.total_Page.Location = new System.Drawing.Point(598, 562);
            this.total_Page.Name = "total_Page";
            this.total_Page.Size = new System.Drawing.Size(14, 16);
            this.total_Page.TabIndex = 54;
            this.total_Page.Text = "1";
            // 
            // page_Number
            // 
            this.page_Number.AutoSize = true;
            this.page_Number.Location = new System.Drawing.Point(574, 562);
            this.page_Number.Name = "page_Number";
            this.page_Number.Size = new System.Drawing.Size(14, 16);
            this.page_Number.TabIndex = 53;
            this.page_Number.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(616, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "bản ghi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Trang";
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(809, 537);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(66, 57);
            this.btn_Last.TabIndex = 48;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(741, 537);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(64, 57);
            this.btn_Next.TabIndex = 47;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(441, 535);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(62, 57);
            this.btn_Prev.TabIndex = 46;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(369, 535);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(66, 57);
            this.btn_First.TabIndex = 45;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // UCQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total_Records);
            this.Controls.Add(this.total_Page);
            this.Controls.Add(this.page_Number);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.dgv_DSLop);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_viewStudents);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Name = "UCQLLH";
            this.Size = new System.Drawing.Size(1050, 631);
            this.Load += new System.EventHandler(this.UCQLLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DSLop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_viewStudents;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label total_Records;
        private System.Windows.Forms.Label total_Page;
        private System.Windows.Forms.Label page_Number;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}
