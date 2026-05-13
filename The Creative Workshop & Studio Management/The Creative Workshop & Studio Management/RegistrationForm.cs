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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCreativeWorkshop_StudioManagementDataSet.REGISTRATION' table. You can move, or remove it, as needed.
            

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Registration values ('" + textBox1.Text.ToString()+"','" + textBox2.Text.ToString()+"','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            this.rEGISTRATIONTableAdapter.Fill(this.theCreativeWorkshop_StudioManagementDataSet.REGISTRATION);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Registration set MEMBER_ID=" + textBox2.Text + ", WORKSHOP_ID=" + textBox1.Text + ", REGISTRATIONDATE='" + textBox4.Text + "' where REGISTRATIONID=" + textBox3.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Registration where REGISTRATIONID=" + textBox3.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
