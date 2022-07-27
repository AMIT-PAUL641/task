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
    public partial class soldcar : UserControl
    {
        public soldcar()
        {
            InitializeComponent();
        }

        private void buttonSold_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
             SqlDataAdapter sda = new SqlDataAdapter("Select bookedid From usertable where userphn='" + textBoxId.Text.Trim() + "' ", con);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             
             if (dt.Rows[0][0].ToString() != "0")
                    {
                        string s = dt.Rows[0][0].ToString();
                        
                        MessageBox.Show("Car is Successfully Sold");

                        SqlCommand cmd1 = new SqlCommand(@"Update [dbo].[car]  SET [SaleAmount]=[SaleAmount]+1 WHERE [id] ='" + s + "'", con);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        SqlCommand cmd = new SqlCommand(@"Update [dbo].[usertable]  SET [bookedid]=0 WHERE [userphn] = '" + textBoxId.Text + "' ", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        


                    }
                    else
                    {
                        MessageBox.Show("Booked ID Not Found");
                    }
                   
        }
    }
}
