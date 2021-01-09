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
    public partial class Customer : Form
    {
        private int mov,movX,movY;
        Thread t;
        public Customer()
        {
            InitializeComponent();
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
        // Close button
        //
        private void CloseLbl_Click(object sender, EventArgs e)
        {
            int value = (int)MessageBox.Show("Do you want to exit!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (value == 6)
            {
                this.Dispose();
                t = new Thread(NextPage);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }
        //
        // Running Role form after closing this form.
        //
        private void NextPage() {
            Application.Run(new Role());
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
        private void MinimizeLbl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        //
        //
        private void MinimizeLbl_MouseHover(object sender, EventArgs e)
        {
            MinimizeLbl.ForeColor = Color.FromArgb(255,180,31);
        }
        //
        //
        //
        private void CustomerControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        //
        //
        //
        private void CustomerControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //
        //
        //
        private void CustomerControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
              this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        //
        //
        //
        private void MinimizeLbl_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLbl.ForeColor = Color.Orange;
        }
        //
        // for submitting customer review
        //
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            customerNameBox.Text = "";
            customerEmailBox.Text = "";
            customerNumberBox.Text = "";
            suggestionBox.Text = "";
        }
    }
}
