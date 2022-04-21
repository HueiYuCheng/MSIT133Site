using Dapper;
using Microsoft.AspNetCore.Mvc;
using MSIT133Site.Models;
using MSIT133Site.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterRequestModel request)
        {
            var result =  _memberService.Register(request);
            return Ok(result);
        }
    }
}
