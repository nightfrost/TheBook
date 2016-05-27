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
    
    public partial class ConnectInformation : Form
    {
        
        public ConnectInformation()
        {
            InitializeComponent();
            
        }

        private void TestConnButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + SRVTxtBox.Text + ";Initial Catalog=" + DBTxtBox.Text + ";User ID=UserName;Password=Password";
            testConnection(connectionString);
        }
        private bool testConnection(string connectionString)
        {
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                MessageBox.Show("Connected.");
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot connect. See details: {0}", ex);
                return false;
            }
        }
    }
}
