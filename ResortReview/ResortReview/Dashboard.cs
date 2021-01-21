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
    public partial class Dashboard : UserControl
    {
        bool sortStatus = false;
        bool resetStatus = false;
        public Dashboard()
        {
            InitializeComponent();
            ResortAnalysis();
           
        }

        public void ResortAnalysis()
        {
            CustomerReview review = new CustomerReview();
            List<CustomerReview> Review_Of_Customer = review.ReviewList();
            DataTable dt = ConvertToDataTable(Review_Of_Customer);
            customerReviewData.DataSource = dt;
            customerReviewData.RowHeadersVisible = false;
            customerReviewData.RowHeadersWidth = 100;

            Dictionary<string,int> chartData = Chart(Review_Of_Customer);
            foreach(KeyValuePair<string,int> chart_data in chartData){
                RatingGraph.Series["Customers Rating"].Points.AddXY(chart_data.Key, chart_data.Value);
            }
        }
        public static DataTable ConvertToDataTable(List<CustomerReview> review)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CustomerReview));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                if (prop.Name != "AllRatings")
                {
                    table.Columns.Add(prop.Name);
                }
                else
                {
                    List<string> criterias = CriteriaList();
                    foreach (var criteria in criterias)
                    {
                        table.Columns.Add(criteria);
                    }
                }
            }

            if (review != null)
            {
                foreach (CustomerReview item in review)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        if (prop.Name != "AllRatings")
                        {
                            if (prop.Name == "RatingDate")
                            {
                                DateTime Date = (DateTime)prop.GetValue(item);
                                string ConvertedDate = Date.ToString("yyyy/MM/d");
                                row[prop.Name] = ConvertedDate;
                            }
                            else {
                                row[prop.Name] = prop.GetValue(item);
                            }
                            
                        }
                        else
                        {
                            foreach (KeyValuePair<String, int> submittedReview in item.AllRatings)
                            {
                                row[submittedReview.Key] = submittedReview.Value;
                            }
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public Dictionary<string,int> Chart(List<CustomerReview> data) { 
          Dictionary<string,int> ChartData = new Dictionary<string, int>();
            //Dictionary<string, int> ChartData = new Dictionary<string, int>();

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CustomerReview));

            if (data != null) {
                foreach (CustomerReview item in data) {
                    foreach (PropertyDescriptor prop in properties) {
                        if (prop.Name == "AllRatings") {
                            foreach (KeyValuePair<string, int> ratingData in item.AllRatings) {
                                if (ChartData.ContainsKey(ratingData.Key))
                                {
                                    ChartData[ratingData.Key] = ChartData[ratingData.Key] + ratingData.Value;
                                }
                                else {
                                    ChartData.Add(ratingData.Key, ratingData.Value);
                                }
                            }
                        }
                    }
                }
            }
            return ChartData;
        }
        //
        // CriteriaList method is used for listing out all the specified criteria and storing to criteriaCollection list.
        //
        public static List<string> CriteriaList()   
        {
            List<string> CriteriaCollection = new List<string>();
            string data = ReadWrite.ReadFromText(path: "CriteriaCollection.txt");

            if (data != "")
            {
                data = data.Trim().Substring(1, data.Trim().Length - 3);
                if (!data.Contains(","))
                {
                    CriteriaCollection.Add(data);
                }
                else
                {
                    CriteriaCollection = data.Split(',').ToList();
                }
            }

            return CriteriaCollection;
        }
        //
        // method for sorting review list
        //
        private void SortBtn_Click(object sender, EventArgs e)
        {
            if (sortStatus == false)
            {
                sortStatus = true;
                resetStatus = false;
                CustomerReview cr = new CustomerReview();
                List<CustomerReview> review = cr.ReviewList();
                DataTable sortedTable = ConvertToDataTable(cr.SortData(review));
                customerReviewData.DataSource = sortedTable;
            }
            else {
                MessageBox.Show("Review List has been already sorted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        //
        // method for reseting review list
        //
        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (resetStatus == false) {
                sortStatus = false;
                resetStatus = true;
                CustomerReview cr = new CustomerReview();
                List<CustomerReview> review = cr.ReviewList();
                DataTable resetTable = ConvertToDataTable(review);
                customerReviewData.DataSource = resetTable;
            }
            else
            {
                MessageBox.Show("Review List has been already reset!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
