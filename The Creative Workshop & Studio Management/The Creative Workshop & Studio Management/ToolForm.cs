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
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCreativeWorkshop_StudioManagementDataSet.TOOL' table. You can move, or remove it, as needed.
            

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tool values ('" + txtToolID.Text.ToString() + "','" + txtStudioID.Text.ToString() + "','" + txtDescription.Text.ToString() + "','" + txtCondition.Text.ToString() + "','"+ txtAvailability.Text.ToString() + "','"+txtToolName.Text.ToString()+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            this.tOOLTableAdapter.Fill(this.theCreativeWorkshop_StudioManagementDataSet.TOOL);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Tool set STUDIOID='" + txtStudioID.Text.ToString() + "', DESCRIPTION='" + txtDescription.Text.ToString() + "', CONDITION='" + txtCondition.Text.ToString() + "', AVAILABILITYSTATUS='" + txtAvailability.Text.ToString() + "', TOOLNAME='" + txtToolName.Text.ToString() + "' where TOOLID='" + txtToolID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tool where TOOLID='" + txtToolID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOOLTableAdapter.FillBy(this.theCreativeWorkshop_StudioManagementDataSet.TOOL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOOLTableAdapter.FillBy1(this.theCreativeWorkshop_StudioManagementDataSet.TOOL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
