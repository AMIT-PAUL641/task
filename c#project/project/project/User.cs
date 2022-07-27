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
using System.IO;


namespace project
{
   
    public partial class User : Form
    {
        public static string Id;
        public static string Pass;
        
        public User()
        {
            InitializeComponent();
        }

        

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void allManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void allProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carListToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [id],[name],[price],[details],[image],[availableCar] from [dbo].[car] ", con);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            con.Close();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From car where name='" + textBox1.Text.Trim() + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter an = new SqlDataAdapter("Select price,details,availableCar,image,id From car where name='" + textBox1.Text.Trim() + "' ", con);

                DataTable dt1 = new DataTable();
                an.Fill(dt1);
                string a = dt1.Rows[0][0].ToString();
                pricetextbox.Text = a;
                nametextbox.Text = textBox1.Text;
                string b = dt1.Rows[0][1].ToString();
                detailstextbox.Text = b;
                string c = dt1.Rows[0][2].ToString();
                availabletextbox.Text = c;
                string d = dt1.Rows[0][4].ToString();
                idtextBox.Text = d;

                //pic
                SqlCommand cmd;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\VS2017 Project\WindowsForms\WindowsForms\Database.mdf;" + "Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select image From car where name='" + textBox1.Text.Trim() + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pictureBox1.Image = new Bitmap(ms);


                }
                con.Close();
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Not Found");
                textBox1.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From car where id='" + textBox2.Text.Trim() + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter an = new SqlDataAdapter("Select price,details,availableCar,image,name,id From car where id='" + textBox2.Text.Trim() + "' ", con);

                DataTable dt1 = new DataTable();
                an.Fill(dt1);
                string a = dt1.Rows[0][0].ToString();
                pricetextbox.Text = a;
                string b = dt1.Rows[0][1].ToString();
                detailstextbox.Text = b;
                string c = dt1.Rows[0][2].ToString();
                availabletextbox.Text = c;
                string d = dt1.Rows[0][4].ToString();
                nametextbox.Text = d;
                string f= dt1.Rows[0][5].ToString();
                idtextBox.Text = f;
                //pic
                SqlCommand cmd;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\VS2017 Project\WindowsForms\WindowsForms\Database.mdf;" + "Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select image From car where id='" + textBox2.Text.Trim() + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pictureBox1.Image = new Bitmap(ms);


                }
                con.Close();
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Not Found");
                textBox2.Text = "";
            }
            
        }

        private void dataGridViewmanager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHome ob = new FormHome();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }
        public User(string i,string p)
        {
            Id = i;
            Pass = p;
            
        }


        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text=="")
            {
                MessageBox.Show("Not Booked");
            }
            else
            MessageBox.Show("Booked");
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand(@"Update [dbo].[usertable]  SET [bookedid]='" + idtextBox.Text + "' WHERE [username] ='" + Id + "' and [userpass] ='" + Pass + "'", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            SqlCommand cmd2 = new SqlCommand(@"Update [dbo].[car]  SET [availableCar]=[availableCar]-1 WHERE [id] ='" + idtextBox.Text + "'", con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            
        }
    
        
    }
}
