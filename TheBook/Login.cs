using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBook
{
    public partial class Login : Form
    {
        string picturePath = @"C:\Users\Sanic\Documents\visual studio 2013\Projects\TheBook\TheBook\img\Drawing.png";




        public Login()
        {
            InitializeComponent();
            usernameBox.Text = "Enter Username";

            passwordBox.MaxLength = 14;
            passwordBox.Text = "Enter Password";
            
            frontImage.Image = Image.FromFile(picturePath);
        }




        private void usernameBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameBox.Text = "";
        }
        private void passwordBox_Enter(object sender, EventArgs e)
        {
            passwordBox.Text = "";
            passwordBox.PasswordChar = '•';
        }

        //Opens Register Form
        private void registerButton_Click(object sender, EventArgs e)
        {
            using (Register reg = new Register())
            {
                reg.ShowDialog(this);
            }
        }

        

       
        
    }
}
