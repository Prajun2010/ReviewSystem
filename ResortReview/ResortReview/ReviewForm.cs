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
    public partial class ReviewForm : Form
    {
        private int mov,movX,movY;
        private List<string> criteriaTitle = new List<string>();
        //list of InsertedCriteria object => Object of review tile seen in the review section of customer rating.
        private List<CriteriaTiles> AllCriteria = new List<CriteriaTiles>();

        private Dictionary<string, int> Criteria_Value = new Dictionary<string, int>();

        Thread t;
        public ReviewForm()
        {
            InitializeComponent();
            SetCriteria();
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
        //setting criteria
        //
        private void SetCriteria() {
            string data = ReadWrite.ReadFromText(path:"CriteriaCollection.txt");
            
            if (data != "") {
                data = data.Trim().Substring(1, data.Trim().Length - 3); 
                if (!data.Contains(","))
                {
                    criteriaTitle.Add(data);
                }
                else {
                    criteriaTitle = data.Split(',').ToList();
                }
            }

            setCriteriaBlock(); // this method creates multiple tiles for set criteria.
        }

        //method for adding rating dynamically in customer UI
        private void setCriteriaBlock() {
            if (criteriaTitle.Count() != 0) {

                foreach (string title in criteriaTitle) {
                    AllCriteria.Add(new CriteriaTiles(title));
                }
            }
            //Console.WriteLine(criteriaTitle.Count());
            foreach (CriteriaTiles criteria in AllCriteria) {
                RatingLayout.Controls.Add(criteria);
            }
        }
        //
        // Close button
        //
        private void CloseLbl_Click(object sender, EventArgs e)
        {
            int value = (int)MessageBox.Show("Do you want to exit!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (value == 6){

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
        //This method is created to store criteria title as key and it's rating as value in dictionary 
        //
        private void KeyValue() {
            for (int i = 0; i < criteriaTitle.Count();i++) {
                Criteria_Value[criteriaTitle[i]] = AllCriteria[i].Review;
            }
        }
        //
        // for submitting customer review
        //
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            KeyValue();
            CustomerReview cr = new CustomerReview();
            cr.CustomerName = customerNameBox.Text;
            cr.CustomerEmail = customerEmailBox.Text;
            cr.CustomerNumber = customerNumberBox.Text;
            cr.Suggesstions = suggestionBox.Text;
            cr.AllRatings = Criteria_Value;
            cr.RatingDate = DateTime.Now.ToString("yyyy/MM/d");
            cr.RatingTime = DateTime.Now.ToString("hh:m tt");
            string response = cr.SaveReview(cr);
            if (response == "Success") {
                customerNameBox.Text = "";
                customerEmailBox.Text = "";
                customerNumberBox.Text = "";
                suggestionBox.Text = "";

                foreach (CriteriaTiles criteria in AllCriteria)
                {
                    criteria.Unselect();
                }

                MessageBox.Show("Thank you for the review!", "Review", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
