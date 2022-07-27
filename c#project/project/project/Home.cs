using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace project
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            Formsign ob = new Formsign(); 
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {

            //try

            string id = textId.Text;
            string pass = textpass.Text;
            User n1 = new User(id,pass);
          

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From usertable where username='" + textId.Text.Trim() + "' and userpass='" + textpass.Text.Trim() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                
                    SqlDataAdapter an = new SqlDataAdapter("Select type From usertable where username='" + textId.Text.Trim() + "' and userpass='" + textpass.Text.Trim() + "'", con);

                    DataTable dt1 = new DataTable();
                    an.Fill(dt1);
                    if (dt1.Rows[0][0].ToString() == "1")
                    {

                        FormOwner n = new FormOwner();
                        n.Show();
                        this.Hide();


                    }
                    if (dt1.Rows[0][0].ToString() == "2")
                    {
                        this.Hide();
                        Manager n = new Manager();
                        n.Show();
                    }
                    if (dt1.Rows[0][0].ToString() == "3")
                    {
                        this.Hide();
                        User n = new User();
                        n.Show();
                    }
                }
 

            
            else
                MessageBox.Show("Please Cheak your Usarname Or Password");
           

        }

        private void buttonguest_Click(object sender, EventArgs e)
        {
            User ob = new User();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}

