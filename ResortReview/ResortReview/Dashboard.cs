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
                            row[prop.Name] = prop.GetValue(item);
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
            
;        }

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


    }
}
