using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMWORLD.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VMWORLD.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Login()
        {
            return View();

        }
        public static bool Verfication(string username, string password)
       {
            if ("username" == "verina" && "password" == "12345") 
            {
                return true;
            }
            else
            {
                return false;
            }
           }
}
  }
    

