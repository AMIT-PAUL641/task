﻿using System;
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
    public partial class AddManager : UserControl
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-29BI3TO;Initial Catalog=userinfo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[usertable] ([username],[userpass],[userphn],[useraddress],[type])
     VALUES
           ('" + textBoxName.Text + "','" + textBoxNid.Text + "','" + textBoxPhn.Text + "','" + textBoxAdd.Text + "','1')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ok");
        }
    }
}
