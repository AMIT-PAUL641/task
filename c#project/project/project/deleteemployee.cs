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
    public partial class deleteemployee : UserControl
    {
        public deleteemployee()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
           SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From usertable where userpass='" + textBoxId.Text.Trim() + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[usertable]  WHERE [userpass] = '" + textBoxId.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ok");
                textBoxId.Text = "";
            }
            else
            {
                MessageBox.Show("Not Found");
                textBoxId.Text = "";
            }
        }
    }
}
