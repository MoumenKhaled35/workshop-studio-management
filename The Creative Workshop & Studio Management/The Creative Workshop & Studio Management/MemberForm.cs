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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCreativeWorkshop_StudioManagementDataSet.MEMBER' table. You can move, or remove it, as needed.
           

        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into MEMBER values ('" + txtMemberID.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtPhone.Text.ToString() + "','" +txtFee.Text.ToString() +"','"+txtDate.Text.ToString()+"','"+txtName.Text.ToString()+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            this.mEMBERTableAdapter.Fill(this.theCreativeWorkshop_StudioManagementDataSet.MEMBER);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update MEMBER set EMAIL='" + txtEmail.Text.ToString() + "', PHONENUM='" + txtPhone.Text.ToString() + "', SUBFEE='" + txtFee.Text.ToString() + "', SUBSTARTDATE='" + txtDate.Text.ToString() + "', MEMBERNAME='" + txtName.Text.ToString() + "' where MEMBER_ID='" + txtMemberID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from MEMBER where MEMBER_ID='" + txtMemberID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
