using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMWORLD.Controllers;
using VMWORLD.Models;

namespace VMWORLD.Models
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool Verfication(string username, string password)
        {
           var result= Verfication ("verina","12345");

            return result;

        }

    }
}
