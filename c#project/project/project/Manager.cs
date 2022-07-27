using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void allManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [id],[name],[price],[details],[image],[availableCar],[SaleAmount] from [dbo].[car] ", con);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            con.Close();
        }

        private void deleteManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdd.Controls.Clear();
            panelAdd.Controls.Add(new addcar());
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [username],[userphn],[useraddress],[userpass] from [dbo].[usertable] where [type]=" + '2', con);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            con.Close();
        }

        private void deleteManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelDelete.Controls.Clear();
            panelDelete.Controls.Add(new deletecar());
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHome ob = new FormHome();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        public Manager(string ID)
        {
         
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDelete.Controls.Clear();
            panelDelete.Controls.Add(new soldcar());
        }
    }
}
