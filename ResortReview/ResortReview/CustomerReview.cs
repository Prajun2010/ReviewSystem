using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortReview
{
    public class CustomerReview
    {
        private string path = "OverallReview.json";
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }
        public string Suggesstions { get; set; }
        public DateTime RatingDate { get; set; }
        public DateTime RatingTime { get; set; }
        public Dictionary<string, int> AllRatings { get; set; }

        public string SaveReview(CustomerReview cr) {
            string data = JsonConvert.SerializeObject(cr, Formatting.None);
            ReadWrite.WriteToText(data:data,path:path);
            return "Success";
        }

        public List<CustomerReview> ReviewList()
        {
            string data = ReadWrite.ReadFromText(path);
            if (data != null)
            {
                List<CustomerReview> reviewCollection = JsonConvert.DeserializeObject<List<CustomerReview>>(data);
                return reviewCollection;
            }
            return null;
        }

        public List<CustomerReview> SortData(List<CustomerReview> data) {
            CustomerReview temp;
            if (data != null) {
                for (int j = 0; j <= data.Count - 2; j++)
                {
                    for (int i = 0; i <= data.Count - 2; i++)
                    {
                        if (data[i].RatingDate > data[i + 1].RatingDate)
                        {
                            temp = data[i + 1];
                            data[i + 1] = data[i];
                            data[i] = temp;
                        }   
                    }
                }
                return data;
            }
            return null;
            
        }
    }
}
