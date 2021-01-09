using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using ResortReview.Properties;

/*
 * @author: Prajun Lungeli(L3C1)
 */

namespace ResortReview
{
    public partial class Role : Form
    {
        Thread t;
        private int mov, movX, movY;
        private bool hide = false;
        private bool hidePass = true;
        private static string path = "admin.json";


        public Role()
        {
            InitializeComponent();
            loginPanel.Visible = false;
            basePanel.Height = 250;
            loginError.Visible = false;
        }


        // for adding shadow effect on window
        protected override CreateParams CreateParams
        { 
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        //
        // events for hiding and displaying login pannel
        //
        private void Button1_Click(object sender, EventArgs e)
        {
            if (hide == false) 
            { // for displaying 
                hide = true;
                loginPanel.Visible = true;
                basePanel.Height = 420;
                hidePass = true;

            }
            else
            {// for hiding 
                hide = false;
                loginPanel.Visible = false;
                basePanel.Height = 250;
                loginError.Text = "";
                usernameTxt.Text = "";
                passwordTxt.Text = "";

            }    
            
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            t = new Thread(()=>NextPage("Customer"));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }


        // for admin login -> button name login
        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Console.WriteLine(path);
                LoginProceed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error!", "Error 404!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }
       
        
        // for displaying errors or proceeding to another page according to the authentication status.
        private void LoginProceed() { 
            int proceedStatus = LoginAuthentication.AuthenticateCredential(username: usernameTxt.Text, password: passwordTxt.Text, path: path);

            if (proceedStatus == -1) {
                loginError.Text = "User not found!";
                loginError.Visible = true;
            }
            if (proceedStatus == 0) {
                loginError.Text = "Username and Password Missing!";
                loginError.Visible = true;
            }
            if (proceedStatus == 1) {
                loginError.Text = "Username Missing!";
                loginError.Visible = true;
            }
            if (proceedStatus == 2)
            {
                loginError.Text = "Password Missing!";
                loginError.Visible = true;
            }
            if (proceedStatus == 3)
            {
                this.Dispose();
                t = new Thread(()=>NextPage("Admin"));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            if (proceedStatus == 4)
            {
                loginError.Text = "Invalid Username or Password!";
                loginError.Visible = true;
            }
        }
        //
        // for moving to next thread.
        //
        private void NextPage(string type)
        {
            if (type == "Admin")
            {
                Application.Run(new Admin()); // it will run the new form.
            }
            else{
                Application.Run(new Customer());
            }
            
        }
        //
        // events for displaying user manual 
        //
        private void UserGuide_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Visible = true;
        }
        //
        //evenets for Minimizing windows -> Custom minimize button 
        //
        private void MinimizeLbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        // events for masking and unmasking password
        //
        private void ShowHideBtn_Click(object sender, EventArgs e)
        { 
            if (hidePass == true)
            {
                hidePass = false;
                passwordTxt.UseSystemPasswordChar = false;
                passwordTxt.PasswordChar = '\0';
                showHideBtn.Image = Resources.eye;
            }
            else {
                hidePass = true;
                passwordTxt.UseSystemPasswordChar = true;
                passwordTxt.PasswordChar = '●';
                showHideBtn.Image = Resources.eyeclosed;
            }
            
            
        }
        //
        // events for completely closing the thread
        //
        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //
        //
        //
        private void CloseLbl_MouseHover(object sender, EventArgs e)
        {
            CloseLbl.ForeColor = Color.Red;
        }
        //
        //
        //
        private void CloseLbl_MouseLeave(object sender, EventArgs e)
        {
            CloseLbl.ForeColor = Color.FromArgb(232, 63, 5);
        }
        //
        //
        //
        private void MinimizeLbl_MouseHover(object sender, EventArgs e)
        {
            MinimizeLbl.ForeColor = Color.FromArgb(255, 180, 31);
        }
        //
        //
        //
        private void MinimizeLbl_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLbl.ForeColor = Color.Orange;
        }
        //
        //
        //
        private void Role_MouseDown(object sender, MouseEventArgs e)
        { // means left button in cliked -> button is down 
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        //
        //
        //
        private void Role_MouseMove(object sender, MouseEventArgs e)
        { 
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
            
        }
        //
        //
        //
        private void Role_MouseUp(object sender, MouseEventArgs e)
        { // means left button isn't cliked -> button is up.
            mov = 0;
            
        }
    }

}
