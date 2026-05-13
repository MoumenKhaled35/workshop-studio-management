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
    public partial class WorkshopForm : Form
    {
        public WorkshopForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");

                string query = @"INSERT INTO WORKSHOP (WORKSHOP_ID, CRAFT, WORKSHOPDATE, WORKSHOPTIME, DURATION, ARTISTID, STUDIOID)
                         VALUES (@id, @craft, @date, @time, @duration, @artistid, @studioid)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@craft", txtCraft.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(txtDate.Text));
                cmd.Parameters.AddWithValue("@time", TimeSpan.Parse(txtTime.Text));
                cmd.Parameters.AddWithValue("@duration", int.Parse(txtDuration.Text));
                cmd.Parameters.AddWithValue("@artistid", int.Parse(txtArtist.Text));
                cmd.Parameters.AddWithValue("@studioid", int.Parse(txtStudio.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Workshop Inserted Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update WORKSHOP set CRAFT='" + txtCraft.Text + "', WORKSHOPDATE='" + txtDate.Text + "', WORKSHOPTIME='" + txtTime.Text + "', DURATION='" + txtDuration.Text + "', ARTISTID='" + txtArtist.Text + "', STUDIOID='" + txtStudio.Text + "' where WORKSHOP_ID=" + txtID.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Workshop Updated Successfully!");
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from WORKSHOP where WORKSHOP_ID=" + txtID.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Workshop Deleted Successfully!");
            LoadData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(
    "SELECT W.WORKSHOP_ID, W.CRAFT, W.WORKSHOPDATE, W.WORKSHOPTIME, W.DURATION, " +
    "W.ARTISTID, W.STUDIOID, " +
    "R.REGISTRATIONID, R.MEMBER_ID, R.REGISTRATIONDATE " +
    "FROM WORKSHOP W " +
    "LEFT JOIN REGISTRATION R " +
    "ON W.WORKSHOP_ID = R.WORKSHOP_ID", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT W.WORKSHOP_ID, W.CRAFT, W.WORKSHOPDATE, W.WORKSHOPTIME, W.DURATION, " +
                "W.ARTISTID, W.STUDIOID, " +
                "R.REGISTRATIONID, R.MEMBER_ID, R.REGISTRATIONDATE " +
                "FROM WORKSHOP W " +
                "LEFT JOIN REGISTRATION R " +
                "ON W.WORKSHOP_ID = R.WORKSHOP_ID", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkshopForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
