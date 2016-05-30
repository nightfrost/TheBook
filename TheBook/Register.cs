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

namespace TheBook
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void regRegister_Click(object sender, EventArgs e)
        {
            if (regPassword.Text == regConfPassword.Text)
            {
                string connectionString = "Data Source=lrdwin81d;" +
                "Initial Catalog=TheBookContacts;" +
                "User id=lrd;" +
                "Password=kairi1273;";

                try { 
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO UserInformation (User, Password) VALUES (@User, @Password)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@User", regUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", regPassword.Text);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception Ex)
                {
                    throw new Exception("Cannot parse data to DB, message:\n{0}", Ex);
                    if (Ex.InnerException != null)
                    {
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        
    }
}
