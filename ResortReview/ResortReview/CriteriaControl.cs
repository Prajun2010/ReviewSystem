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
    public partial class CriteriaControl : UserControl
    {
        string path = "CriteriaCollection.txt";
        public CriteriaControl()
        {
            InitializeComponent();
        }
        //
        //Method for writing specified criteria in criteriacollection json file.
        //
        private void CriteriaBtn_Click(object sender, EventArgs e)
        {
            //here format (1)=> append in same line(i.e Console.Write(data))
            ReadWrite.WriteToText(data: criteriaSpecifyBox.Text, path: path, append:true,format:1);
        }
    }
}
