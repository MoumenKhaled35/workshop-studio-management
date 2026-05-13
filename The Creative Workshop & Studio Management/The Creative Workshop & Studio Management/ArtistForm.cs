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

namespace The_Creative_Workshop___Studio_Management
{
    public partial class ArtistForm : Form
    {
        public ArtistForm()
        {
            InitializeComponent();
        }

        private void ArtistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCreativeWorkshop_StudioManagementDataSet.ARTIST' table. You can move, or remove it, as needed.
            

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ARTIST values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.aRTISTTableAdapter.Fill(this.theCreativeWorkshop_StudioManagementDataSet.ARTIST);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ARTIST set SPECIALTY='" + textBox2.Text + "', EXPERIENCEYEARS=" + textBox3.Text + ", ARTISTNAME='" + textBox4.Text + "' where ARTISTID=" + textBox1.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from ARTIST where ARTISTID=" + textBox1.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
