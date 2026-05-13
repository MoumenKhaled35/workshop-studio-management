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
    public partial class Report4 : Form
    {
        public Report4()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            string query = @"
        SELECT 
            MEMBER.MEMBER_ID,
            MEMBER.MEMBERNAME,
            MEMBER.EMAIL,
            MEMBER.PHONENUM
        FROM MEMBER
        WHERE MEMBER.MEMBER_ID NOT IN
        (
            SELECT REGISTRATION.MEMBER_ID
            FROM REGISTRATION
            INNER JOIN WORKSHOP
            ON REGISTRATION.WORKSHOP_ID = WORKSHOP.WORKSHOP_ID
            WHERE 
                MONTH(WORKSHOP.WORKSHOPDATE) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                AND YEAR(WORKSHOP.WORKSHOPDATE) = YEAR(DATEADD(MONTH, -1, GETDATE()))
        )
        AND MEMBER.MEMBER_ID NOT IN
        (
            SELECT RENTAL.MEMBER_ID
            FROM RENTAL
            WHERE 
                MONTH(RENTAL.PICKUPTIME) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                AND YEAR(RENTAL.PICKUPTIME) = YEAR(DATEADD(MONTH, -1, GETDATE()))
        )";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("All members were active last month.",
                                   "No Results",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                               "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void Report4_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = 450;
            dataGridView1.Height = 200;
        }
    }
}
