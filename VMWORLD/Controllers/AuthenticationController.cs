﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMWORLD.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VMWORLD.Controllers
{
    public class AuthenticationController: Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Confirmation()
        {
            return View();
        }
        public IActionResult Elements()
        {
            return View();
        }
        public IActionResult Generic()
        {
            return View();
        }
       
        public IActionResult Single()
        {
            return View();
        }
        public IActionResult Tracking()
        { 
            return View();
        }

        public IActionResult Login()
        {
            return View();

        }
        public IActionResult Authenticate(string username, string password)
        {
            var result = Customers.Login(username, password);
            if (result == true)
            {
                ViewBag.Message ="Welcome back, Verina to our website";
                return View("Index");
            }
            else
            {
                ViewBag.Message="Wrong username or password";
                return View("Login");
            }
        }
    }
}
