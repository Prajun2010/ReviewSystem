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
            // storing criteria title for cheking redudancy
            List<string> CriteriaCollection;   

            //Reading previous criteria title before adding new criteria to the file.
            //Helps to determine whether the specified criteria is already contained or not.
            if (criteriaSpecifyBox.Text != "")
            {
                string CriteriaTitles = ReadWrite.ReadFromText(path: path);

                if (CriteriaTitles != "")
                {
                    CriteriaTitles = CriteriaTitles.Trim().Substring(1, CriteriaTitles.Trim().Length - 3);
                    //this condition is read if the file contains only single criteria title.
                    if (!CriteriaTitles.Contains(","))
                    {
                        if (criteriaSpecifyBox.Text.ToLower() == CriteriaTitles.ToLower())
                        {
                            // if redudancy found.
                            MessageBox.Show("Criteria already set!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            AddCriteria();
                        }
                    }
                    // this condition is read if the file contains more than one criteria title. 
                    else
                    {
                        //flag:true -> contains redudant title
                        //flag:false -> doesn't contain redudant title
                        bool flag = false;
                        CriteriaCollection = CriteriaTitles.Split(',').ToList();

                        foreach (string similarCriteria in CriteriaCollection)
                        {
                            if (similarCriteria.ToLower() == criteriaSpecifyBox.Text.ToLower()) // check for redudancy 
                            {
                                //set flag to true if redudant title found.
                                flag = true;
                                break;
                            }
                        }
                        if (flag != true)
                        {
                            AddCriteria();
                        }
                        else
                        {
                            MessageBox.Show("Criteria already set!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    AddCriteria();
                }
            }
            else
            {
                MessageBox.Show("Empty criteria can not be set!", "Criteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // method for adding or appending specified critiera in the specified file.
        private void AddCriteria() {
            //here format (1)=> append in same line(i.e Console.Write(data))
            ReadWrite.WriteToText(data: criteriaSpecifyBox.Text, path: path, append: true, format: 1);
            MessageBox.Show("Criteria Set successfully!", "Criteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            criteriaSpecifyBox.Text = "";
        }
    }
}