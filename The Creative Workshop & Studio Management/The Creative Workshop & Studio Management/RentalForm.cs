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
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT R.RENTALID, " +           
                "R.MEMBER_ID, " +                 
                "T.TOOLID, " +                    
                "T.TOOLNAME, " +                  
                "T.CONDITION, " +                 
                "T.AVAILABILITYSTATUS, " +        
                "R.PICKUPTIME, " +                
                "R.RETURNCONDITION " +            
                "FROM RENTAL R " +
                "INNER JOIN TOOL T " +
                "ON R.TOOLID = T.TOOLID", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Width = 700;
            dataGridView1.Height = 200;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(
    "INSERT INTO RENTAL (MEMBER_ID, TOOLID, RENTALID, PICKUPTIME, RETURNCONDITION) " +
    "VALUES (" +
    txtMemberID.Text + "," +
    txtToolID.Text + "," +
    txtRentalID.Text + ",'" +
    txtPickupTime.Text + "','" +
    txtReturnCondition.Text + "')", con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Inserted Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update RENTAL set MEMBER_ID='" + txtMemberID.Text.ToString() + "', TOOLID='" + txtToolID.Text.ToString() + "', PICKUPTIME='" + txtPickupTime.Text.ToString() + "', RETURNCONDITION='" + txtReturnCondition.Text.ToString() + "' where RENTALID='" + txtRentalID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
                MessageBox.Show("Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from RENTAL where RENTALID=" + txtRentalID.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
