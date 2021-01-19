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
    public partial class example : UserControl
    {
        public int review { set; get; }
        public example(string reviewTitle)
        {
            InitializeComponent();
            this.label1.Text= reviewTitle;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            review = 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            review = 2;
        }
    }
}
