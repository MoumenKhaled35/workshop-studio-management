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
    public partial class Report6 : Form
    {
        public Report6()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");

            string query = @"
        SELECT 
            TOOL.TOOLID,
            TOOL.TOOLNAME,
            TOOL.DESCRIPTION,
            TOOL.CONDITION,
            COUNT(RENTAL.RENTALID) AS TOTALRENTALS
        FROM TOOL
        LEFT JOIN RENTAL
        ON TOOL.TOOLID = RENTAL.TOOLID
        GROUP BY 
            TOOL.TOOLID,
            TOOL.TOOLNAME,
            TOOL.DESCRIPTION,
            TOOL.CONDITION
        ORDER BY TOTALRENTALS DESC";

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
                    MessageBox.Show("No tools found.",
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Report6_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = 500;
            dataGridView1.Height = 200;
        }
    }
}
