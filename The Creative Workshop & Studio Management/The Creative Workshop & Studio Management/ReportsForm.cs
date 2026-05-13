using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Creative_Workshop___Studio_Management
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btn_MostPopular_Click(object sender, EventArgs e)
        {
            dgvResult frm = new dgvResult();
            frm.ShowDialog();
        }

        private void btn_Inactive_Click(object sender, EventArgs e)
        {
            Report2 frm = new Report2();
            frm.ShowDialog();
        }

        private void btn_TopArtist_Click(object sender, EventArgs e)
        {
            Report3 frm = new Report3();
            frm.ShowDialog();
        }

        private void btn_Empty_Click(object sender, EventArgs e)
        {
            Report4 frm = new Report4();
            frm.ShowDialog();
        }

        private void btn_MaterialUsage_Click(object sender, EventArgs e)
        {
            Report5 frm = new Report5();
            frm.ShowDialog();
        }

        private void btn_ToolRental_Click(object sender, EventArgs e)
        {
            Report6 frm = new Report6();
            frm.ShowDialog();
        }
    }
}
