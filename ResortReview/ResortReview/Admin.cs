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

namespace ResortReview
{
    public partial class Admin : Form
    {
        Thread t;
        private int mov, movX, movY;
        public Admin()
        {
            InitializeComponent();
            GeneralTitle.Text = "Dashboard";
            dashboard1.BringToFront();
        }
        //
        // for adding shadow effect on window
        //
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
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ButtonMarker.Height = DashboardBtn.Height;
            ButtonMarker.Top = DashboardBtn.Top;
            dashboard1.BringToFront();
            GeneralTitle.Text = "Dashboard";
            passControl1.Clear();

        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            int value = (int)MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (value == 6) {
                Dispose();
                t = new Thread(NextPage);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }

        private void NextPage() {
            Application.Run(new Login());
        }

        private void AdminTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; 
            movX = e.X;
            movY = e.Y;
            
        }

        private void MinimizeLbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            ButtonMarker.Height = LogoutBtn.Height;
            ButtonMarker.Top = LogoutBtn.Top;
            t = new Thread(NextPage);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            Dispose();
            passControl1.Clear();
        }

        private void PasswordChangeBtn_Click(object sender, EventArgs e)
        {
            ButtonMarker.Height = PasswordChangeBtn.Height;
            ButtonMarker.Top = PasswordChangeBtn.Top;
            passControl1.BringToFront();
            GeneralTitle.Text = "Password Change";
        }

        private void CriteriaBtn_Click(object sender, EventArgs e)
        {
            ButtonMarker.Height = CriteriaBtn.Height;
            ButtonMarker.Top = CriteriaBtn.Top;
            criteriaControl1.BringToFront();
            GeneralTitle.Text = "Form Criteria";
            passControl1.Clear();

        }

        private void passControl1_Load(object sender, EventArgs e)
        {

        }

        private void AdminTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void AdminTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1) {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }            
        }
    }
}
