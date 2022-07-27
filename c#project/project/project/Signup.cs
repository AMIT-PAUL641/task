using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Formsign : Form
    {
        public Formsign()
        {
            InitializeComponent();
        }

        private void sign_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormHome ob = new FormHome();
            this.Hide();
            ob.ShowDialog();
            this.Close();

        }

        private void buttonsign_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            
            string name = this.textBoxName.Text;
            string id = this.textBoxpass.Text;
            string num = this.textBoxNum.Text;
            string add = this.textBoxAdd.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(num) || string.IsNullOrEmpty(add))
            {
                MessageBox.Show("Please,Fill Up All");
            }



            int i = 11;
            //int result = 0;

            if (i < num.Length)
            {
                MessageBox.Show("Invalid phone  number");
            }
            int minLength = 8;


            if (minLength < id.Length && id.Any(char.IsUpper) && id.Any(char.IsLower) && id.Any(char.IsSymbol) && id.Any(char.IsDigit))
            {
                MessageBox.Show("Sign Up Successfully");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[usertable] ([username],[userpass],[userphn],[useraddress],[type])
     VALUES
           ('" + textBoxName.Text + "','" + textBoxpass.Text + "','" + textBoxNum.Text + "','" + textBoxAdd.Text + "','3')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }

            else
                MessageBox.Show("Warning! Your password should be a combination of upper and lower case characters, digits, and symbols. ");


               
           



        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
