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
    public partial class Splashscreen : Form
    {
        Thread t;
        public Splashscreen()
        {
            InitializeComponent();
        }
        //
        // CreateParams constructor override to display dropshadow effect on form. 
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
        //
        //timer for repeteadly calling itself -> for progress bar
        //
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Enabled = true;
            loginProgressBar.Increment(2);
            progressStatus.Text = loginProgressBar.Value.ToString() + "%";

            if (loginProgressBar.Value == 100) {
                loginTimer.Enabled = false;
                this.Dispose();
                t = new Thread(NextPage);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }
        //
        // method for running next thread
        //
        private void NextPage() {
            Application.Run(new Role());
        }
       
    }
}
