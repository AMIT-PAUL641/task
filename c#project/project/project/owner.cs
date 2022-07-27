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
    public partial class FormOwner : Form
    {
        public FormOwner()
        {
            InitializeComponent();
        }

        private void FormOwner_Load(object sender, EventArgs e)
        {

        }
        
        

        private void deleteManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdd.Controls.Clear();
            panelAdd.Controls.Add(new AddManager());
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome ob = new FormHome();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void allManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [username],[userphn],[useraddress],[userpass] from [dbo].[usertable] where [type]="+'1', con);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            con.Close();
        }

        private void deleteManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelDelete.Controls.Clear();
            panelDelete.Controls.Add(new DeleteManager());
        }

        private void panelAll_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdd.Controls.Clear();
            panelAdd.Controls.Add(new AddEmployee());
        }

        private void deleteEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelDelete.Controls.Clear();
            panelDelete.Controls.Add(new deleteemployee());
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void allProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [dbo].[car]", con);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            con.Close();
        }
    }
}
