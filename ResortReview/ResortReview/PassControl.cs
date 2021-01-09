using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortReview
{
    public partial class PassControl : UserControl
    {
        private string path = "admin.json";
        public PassControl()
        {
            InitializeComponent();
        }

        private void PassChangeBtn_Click(object sender, EventArgs e)
        {
            int response = ReadCredential(usernameValue.Text,userOldPass.Text,path);
            ResponseValidation(response);
        }
        //
        //
        //
        private int ReadCredential(string username, string password, string path) {
            int check = LoginAuthentication.AuthenticateCredential(username:username,password:password,path:path);
            if (check != -1) {
                return check;    
            }
            return -1;
        }

        private void ResponseValidation(int response) {
            if (response == 0)
            {
                if (userNewPass.Text != "")
                {
                    ErrorMsgTitle.Text = "Admin Username and Old Password Missing!";
                }
                else if (userNewPass.Text == "")
                {
                    ErrorMsgTitle.Text = "Admin Credential Missing!";
                }

            }
            else if (response == 1)
            {
                if (userNewPass.Text != "")
                {
                    ErrorMsgTitle.Text = "Admin Username Missing!";
                }
                else if (userNewPass.Text == "")
                {
                    ErrorMsgTitle.Text = "Admin Username and New Password Missing!";
                }

            }
            else if (response == 2)
            {
                if (userNewPass.Text != "")
                {
                    ErrorMsgTitle.Text = "Admin Old Password Missing!";
                }
                else if (userNewPass.Text == "")
                {
                    ErrorMsgTitle.Text = "Admin Old Password and New Password Missing!";
                }

            }
            else if (response == 3)
            {
                if (userNewPass.Text != "")
                {
                    Change();
                }
                else if (userNewPass.Text == "")
                {
                    ErrorMsgTitle.Text = "Admin New Password Missing!";
                }

            }
            else if (response == 4)
            {
                if (userNewPass.Text != "")
                {
                    ErrorMsgTitle.Text = "Admin current Login Credential is invalid!";
                }
                else if (userNewPass.Text == "")
                {
                    ErrorMsgTitle.Text = "New Password Missing!";
                }
            }
            else
            {
                ErrorMsgTitle.Text = "Provided Admin account not found!";
            }

        }
        private void Change()
        {
            AdminCredential ac = new AdminCredential();
            ac.Username = usernameValue.Text;
            ac.Password = userNewPass.Text;
            string changeResponse= ac.ChangeCredential(adminData:ac,append:false,path:path);
            if (changeResponse == "Success")
            {
                MessageBox.Show("New password successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernameValue.Text = "";
                userOldPass.Text = "";
                userNewPass.Text = "";
                ErrorMsgTitle.Text = "";
            }
        }

        public void Clear() {
            usernameValue.Text = "";
            userOldPass.Text = "";
            userNewPass.Text = "";
            ErrorMsgTitle.Text = "";
        }
    }
}
