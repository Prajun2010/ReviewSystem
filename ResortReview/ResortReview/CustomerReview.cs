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
        public string RatingDate { get; set; }
        public string RatingTime { get; set; }
        public Dictionary<string, int> AllRatings { get; set; }

        public string SaveReview(CustomerReview cr) {
            string data = JsonConvert.SerializeObject(cr, Formatting.None);
            ReadWrite.WriteToText(data:data,path:path);
            return "Success";
        }

        public List<CustomerReview> ReviewList() {
            string data = ReadWrite.ReadFromText(path);
            if (data != null) {
                List<CustomerReview> reviewCollection = JsonConvert.DeserializeObject<List<CustomerReview>>(data);
                return reviewCollection;
            }
            return null;
        }
    }
}
