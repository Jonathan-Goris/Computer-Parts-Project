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

namespace Splash_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SqlCommand CMD = new SqlCommand;

            CMD.CommandText = "Select * From Where Username = @Uname AND Password = @Pword";
            CMD.Parameters.Add("@Uname", SqlDbType.VarChar, 50, "Username");
            CMD.Parameters["@Uname"].Value = UsernameTextBox.Text;
            CMD.Parameters.Add("@Pword", SqlDbType.VarChar, 50, "Password");
            CMD.Parameters["@Pword"].Value = UsernameTextBox.Text;

            if (/*Enter condtion for successful sign in*/)
            {
                // Enter product form here
            }
            else
            {
                MessageBox.Show("Username or Password are incorrect");
            }
        }

        private void CreateNewAccButton_Click(object sender, EventArgs e)
        {
            //Enter Create New Account form here
        }
    }
}
