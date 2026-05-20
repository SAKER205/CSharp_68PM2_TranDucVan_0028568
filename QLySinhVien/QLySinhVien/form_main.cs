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
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            UCQLSV ucqlsv = new UCQLSV();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(ucqlsv);
            quảnLýSinhViênToolStripMenuItem.Font = new Font(quảnLýSinhViênToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSV ucqlsv = new UCQLSV();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(ucqlsv);
            quảnLýSinhViênToolStripMenuItem.Font = new Font(quảnLýSinhViênToolStripMenuItem.Font, FontStyle.Bold);
            quảnLýLớpToolStripMenuItem.Font = new Font(quảnLýLớpToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLH ucqlh = new UCQLLH();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(ucqlh);
            quảnLýLớpToolStripMenuItem.Font = new Font(quảnLýLớpToolStripMenuItem.Font, FontStyle.Bold);
            quảnLýSinhViênToolStripMenuItem.Font = new Font(quảnLýSinhViênToolStripMenuItem.Font, FontStyle.Regular);
        }
    }
}
