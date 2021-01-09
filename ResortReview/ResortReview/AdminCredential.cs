using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortReview
{
    class AdminCredential
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string ChangeCredential(AdminCredential adminData, bool append, string path) {
            string data = JsonConvert.SerializeObject(adminData, Formatting.None);
            ReadWrite.WriteToText(data: data, append: append, path: path);
            return "Success";
        }
    }
}
