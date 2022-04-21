using Dapper;
using Microsoft.AspNetCore.Mvc;
using MSIT133Site.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Controllers
{
    public class MemberRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IEnumerable<Members> GetList()
        {
            using (var conn = new SqlConnection()) //(_connecString)
            {
                var result = conn.Query<Members>("SELECT * FROM Members");
                return result; 
            }

        }
    }
}
