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
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theCreativeWorkshop_StudioManagementDataSet.MATERIAL' table. You can move, or remove it, as needed.
            

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.mATERIALTableAdapter.Fill(this.theCreativeWorkshop_StudioManagementDataSet.MATERIAL);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into MATERIAL values ('" + txtID.Text.ToString() + "','" + txtQuantity.Text.ToString() + "','" + txtUnit.Text.ToString() + "','" + txtName.Text.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update MATERIAL set QUANTITYAVAILABLE='" + txtQuantity.Text.ToString() + "', MATERIALNAME='" + txtName.Text.ToString() + "', UNIT='" + txtUnit.Text.ToString() + "' where MATERIAL_ID='" + txtID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=TheCreativeWorkshop_StudioManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from MATERIAL where MATERIAL_ID='" + txtID.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
