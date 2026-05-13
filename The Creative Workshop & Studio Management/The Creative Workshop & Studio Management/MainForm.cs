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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberForm frm = new MemberForm();
            frm.ShowDialog();   
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            ArtistForm frm = new ArtistForm();
            frm.ShowDialog();
        }

        private void btnWorkshops_Click(object sender, EventArgs e)
        {
            WorkshopForm frm = new WorkshopForm();
            frm.ShowDialog();
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.ShowDialog();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            RentalForm frm = new RentalForm();
            frm.ShowDialog();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            MaterialForm frm = new MaterialForm();
            frm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTool_Click_1(object sender, EventArgs e)
        {
            ToolForm frm = new ToolForm();
            frm.ShowDialog();
        }

        private void btn_Studio_Click(object sender, EventArgs e)
        {
            StudioForm frm = new StudioForm();
            frm.ShowDialog();
        }
    }
}
