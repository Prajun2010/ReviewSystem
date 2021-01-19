using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResortReview.Properties;

/*
 * 
 */
namespace ResortReview
{
    public partial class CriteriaTiles : UserControl
    {
        public int Review { get; set; }
        private bool RateOneClicked = false;
        private bool RateTwoClicked = false;
        private bool RateThreeClicked = false;
        private bool RateFourClicked = false;
        private bool RateFiveClicked = false;
        public CriteriaTiles(string criteriaName)
        {
            InitializeComponent();
            RateOne.Image = Resources.white_star;
            RateTwo.Image = Resources.white_star;
            RateThree.Image = Resources.white_star;
            RateFour.Image = Resources.white_star;
            RateFive.Image = Resources.white_star;
            this.criteriaName.Text = criteriaName;
            Review = 0;
        }
        
        private void RateOne_Click(object sender, EventArgs e)
        {
            if (RateOneClicked == false)
            {
                RateOneClicked = true;
                RateTwoClicked = false;
                RateThreeClicked = false;
                RateFourClicked = false;
                RateFiveClicked = false;
                RateOne.Image = Resources.star_filled_20;
                RateTwo.Image = Resources.white_star;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 1;
            }
            else {
                RateOneClicked = false;
                RateOne.Image = Resources.white_star;
                RateTwo.Image = Resources.white_star;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 0;
            }
            
        }

        private void RateTwo_Click(object sender, EventArgs e)
        {
            if (RateTwoClicked == false)
            {
                RateTwoClicked = true;
                RateOneClicked = false;
                RateThreeClicked = false;
                RateFourClicked = false;
                RateFiveClicked = false;
                RateOne.Image = Resources.star_filled_20;
                RateTwo.Image = Resources.star_filled_20;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 2;
            }
            else {
                RateTwoClicked = false;
                RateOne.Image = Resources.white_star;
                RateTwo.Image = Resources.white_star;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 0;

            }
                
        }

        private void RateThree_Click(object sender, EventArgs e)
        {
            if (RateThreeClicked == false)
            {
                RateThreeClicked = true;
                RateOneClicked = false;
                RateTwoClicked = false;
                RateFourClicked = false;
                RateFiveClicked = false;
                RateOne.Image = Resources.star_filled_20;
                RateTwo.Image = Resources.star_filled_20;
                RateThree.Image = Resources.star_filled_20;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 3;
            }
            else {
                RateThreeClicked = false;
                RateOne.Image = Resources.white_star;
                RateTwo.Image = Resources.white_star;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 0;
            }
        }

        private void RateFour_Click(object sender, EventArgs e)
        {
            if (RateFourClicked == false)
            {
                RateFourClicked = true;
                RateOneClicked = false;
                RateTwoClicked = false;
                RateThreeClicked = false;
                RateFiveClicked = false;
                RateOne.Image = Resources.star_filled_20;
                RateTwo.Image = Resources.star_filled_20;
                RateThree.Image = Resources.star_filled_20;
                RateFour.Image = Resources.star_filled_20;
                RateFive.Image = Resources.white_star;
                Review = 4;
            }
            else
            {
                RateFourClicked = false;
                RateOne.Image = Resources.white_star;
                RateTwo.Image = Resources.white_star;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 0;
            }
        }

        private void RateFive_Click(object sender, EventArgs e)
        {
            if (RateFiveClicked == false)
            {
                RateFiveClicked = true;
                RateFourClicked = false;
                RateOneClicked = false;
                RateTwoClicked = false;
                RateThreeClicked = false;
                RateOne.Image = Resources.star_filled_20;
                RateTwo.Image = Resources.star_filled_20;
                RateThree.Image = Resources.star_filled_20;
                RateFour.Image = Resources.star_filled_20;
                RateFive.Image = Resources.star_filled_20;
                Review = 5;
            }
            else {
                RateFiveClicked = false;
                RateOne.Image = Resources.white_star;
                RateTwo.Image = Resources.white_star;
                RateThree.Image = Resources.white_star;
                RateFour.Image = Resources.white_star;
                RateFive.Image = Resources.white_star;
                Review = 0;
            }
            
        }
        //
        //Method to clear selected rating and assigning rating/ review value to 0
        //
        public void Unselect() {
            RateOne.Image = Resources.white_star;
            RateTwo.Image = Resources.white_star;
            RateThree.Image = Resources.white_star;
            RateFour.Image = Resources.white_star;
            RateFive.Image = Resources.white_star;
            Review = 0;
        }
    }
    
}
