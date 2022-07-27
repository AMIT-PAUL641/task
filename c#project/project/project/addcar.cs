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
    public partial class addcar : UserControl
    {
        public addcar()
        {
            InitializeComponent();
        }
        string imgLocation = "";

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            string name = this.nametextbox.Text;
            string id = this.idtextbox.Text;
            string num = this.pricetextbox.Text;
            string add = this.detailstextbox.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(num) || string.IsNullOrEmpty(add))
            {
                MessageBox.Show("Please,Fill Up All");
            }
            else
                MessageBox.Show("Data Saved Successfully");

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[car]([id],[name],[price] ,[details],[availableCar],[image])
     VALUES('" + idtextbox.Text + "','" + nametextbox.Text + "','" + pricetextbox.Text + "','" + detailstextbox.Text + "','"+availabletextbox.Text + "',@images)", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
    }
}
 