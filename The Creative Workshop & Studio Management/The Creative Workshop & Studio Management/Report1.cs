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
    public partial class dgvResult : Form
    {
        public dgvResult()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");

            string query = @"
        SELECT TOP 1
            WORKSHOP.WORKSHOP_ID,
            WORKSHOP.CRAFT,
            WORKSHOP.WORKSHOPDATE,
            STUDIO.STUDIONAME,
            ARTIST.ARTISTNAME,
            COUNT(REGISTRATION.MEMBER_ID) AS TOTALPARTICIPANTS
        FROM WORKSHOP
        INNER JOIN REGISTRATION 
        ON WORKSHOP.WORKSHOP_ID = REGISTRATION.WORKSHOP_ID
        INNER JOIN STUDIO 
        ON WORKSHOP.STUDIOID = STUDIO.STUDIOID
        INNER JOIN ARTIST 
        ON WORKSHOP.ARTISTID = ARTIST.ARTISTID
        WHERE 
            MONTH(WORKSHOP.WORKSHOPDATE) = MONTH(DATEADD(MONTH, -1, GETDATE()))
            AND YEAR(WORKSHOP.WORKSHOPDATE) = YEAR(DATEADD(MONTH, -1, GETDATE()))
        GROUP BY 
            WORKSHOP.WORKSHOP_ID,
            WORKSHOP.CRAFT,
            WORKSHOP.WORKSHOPDATE,
            STUDIO.STUDIONAME,
            ARTIST.ARTISTNAME
        ORDER BY TOTALPARTICIPANTS DESC";

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
                    MessageBox.Show("No workshops found for last month.",
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

        private void dgvResult_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = 500;
            dataGridView1.Height = 200;
        }
    }
}
