using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index(string userName,int age)
        {
            System.Threading.Thread.Sleep(10000);
            if (String.IsNullOrEmpty(userName))
            {
                userName = "Ajax";
            }
            return Content($"Hello {userName}, You are {age} years old.", "text/plain", System.Text.Encoding.UTF8);
        }
    }
}
