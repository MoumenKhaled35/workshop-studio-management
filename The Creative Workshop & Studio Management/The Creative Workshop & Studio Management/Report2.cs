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
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            string query = @"
        SELECT 
            STUDIO.STUDIOID,
            STUDIO.STUDIONAME
        FROM STUDIO
        WHERE STUDIO.STUDIOID NOT IN
        (
            SELECT WORKSHOP.STUDIOID
            FROM WORKSHOP
            WHERE 
                MONTH(WORKSHOP.WORKSHOPDATE) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                AND YEAR(WORKSHOP.WORKSHOPDATE) = YEAR(DATEADD(MONTH, -1, GETDATE()))
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
                    MessageBox.Show("All studios had workshops last month.",
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
    }
}
