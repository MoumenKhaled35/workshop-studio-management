using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Creative_Workshop___Studio_Management
{
    public partial class StudioForm : Form
    {
        public StudioForm()
        {
            InitializeComponent();
        }

        private void StudioForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCreativeWorkshop_StudioManagementDataSet.STUDIO' table. You can move, or remove it, as needed.
            

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Studio values ('" + txtStudioID.Text.ToString() + "','" + txtMaxCapacity.Text.ToString() + "','" + txtStudioName.Text.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            this.sTUDIOTableAdapter.Fill(this.theCreativeWorkshop_StudioManagementDataSet.STUDIO);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Studio set MAXCAPACITY=" + txtMaxCapacity.Text + ", STUDIONAME='" + txtStudioName.Text + "' where STUDIOID=" + txtStudioID.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Studio where STUDIOID=" + txtStudioID.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
