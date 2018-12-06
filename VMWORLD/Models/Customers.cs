using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMWORLD.Models
{
    public class Customers
    {
        public int ID;
        public string address;
        public string phoneNumber;
        public string username { get; set; }
        public string password { get; set; }

        public static bool Login(string username, string password)
        {
            if (username == "Verina" & password == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public Customers()
        {

        }
    }
}
    

