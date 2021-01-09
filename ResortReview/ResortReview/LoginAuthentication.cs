using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @author: Prajun Lungeli(L3C1)
 * -1 -> Unexpected Error! or user not found!
 *  0 -> username && password missing 
 *  1 -> Username missing 
 *  2 -> Password missing
 *  3 -> Validation success 
 *  4 -> Validation Error (Invalid username or password!)
 */

namespace ResortReview
{   
    class LoginAuthentication
    {
        
        // method for verifying and validating login credential of an admin.
        public static int AuthenticateCredential(string username, string password, string path) { 

            int verificationStatus = LoginValidation(username:username,password:password, path:path); 

            return verificationStatus;
        }

        // method for login verification
        private static int LoginValidation(string username, string password, string path)
        {
            if (username != "" && password != "")
            {
                int validationStatus = LoginVerification(username: username, password: password, path: path);
                return validationStatus;
            }
            else if (username == "" && password != "")
            {
                return 1;
            }
            else if (password == "" && username != "")
            {
                return 2;
            }
            else if (password == "" && username == "") {
                return 0;
            }
            return -1;
        }


        // method for login validation
        private static int LoginVerification(string username, string password, string path) {
            String data = ReadWrite.ReadFromText(path);
            if (data != null) {
                List<AdminCredential> UserCredential = JsonConvert.DeserializeObject<List<AdminCredential>>(data);
                List<Dictionary<string,string>> credential = UserData(UserCredential);
                
                if (username == credential[0]["Username"] && password == credential[0]["Password"])
                {
                    return 3;
                }
                else {
                    return 4;
                }
            }
            return -1;
        }

        private static List<Dictionary<string,string>> UserData<T>(IList<T> data) {

            //for storing list of dictonary -> [{Key:Value}]
            List<Dictionary<string, string>> allUserCredential = new List<Dictionary<string, string>>();

            // for storing username and password in key:Value format - >{Key:Value}
            Dictionary<string, string> userpass = new Dictionary<string, string>(); 

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            foreach (T value in data) {
                foreach (PropertyDescriptor prop in properties) {
                    userpass.Add(prop.Name.ToString(), prop.GetValue(value).ToString());
                    allUserCredential.Add(userpass);
                }
                
            }

            return allUserCredential;

        }
    }
}
