using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortReview
{
    class CustomerReview
    {
        private string path = "OverallReview.json";
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }
        public string Suggesstions { get; set; }
        public string ReviewDate { get; set; }
        public string RevieTime { get; set; }
        public Dictionary<string, string> AllRatings { get; set; }

        public string SaveReview(CustomerReview cr) {
            string data = JsonConvert.SerializeObject(cr, Formatting.None);
            ReadWrite.WriteToText(data:data,path:path);
            return "Success";
        }
    }
}
