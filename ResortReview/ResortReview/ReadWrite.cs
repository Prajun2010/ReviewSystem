using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortReview
{
    class ReadWrite
    {
        // for writing file
        public static void WriteToText(string path, string data, bool append = true, int format = 0) {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(path, append: append))
            {
                if (append == true)
                {
                    data = data + ",";
                }
                if (format != 0)
                {
                    writer.Write(data); // this is for admin credential(requires format 1 to initiate this condition)
                }
                else {
                    writer.WriteLine(data); // for customer feedback
                }
                
            }
        }
        //
        // for reading file
        //
        public static string ReadFromText(string path) {
            // for checking valid path of the file.
            if (File.Exists(path)) {

                string data; // for storing read data 

                // read till end of the line.
                using (StreamReader reader = new StreamReader(path)) {
                    data = reader.ReadToEnd(); 
                }

                if (data != "")
                {
                    data = "[" + data + "]";
                    return data;
                }
                else {
                    return "";
                }

                
            }

            return null;
        } 
    }
}
