using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Empty2Foo.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Empty2Foo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title ="人员信息输入";
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person p)
        {
            if (ModelState.IsValid)
                return View("ValidateOk");
            else
                return View("ValidateFailed");
        }



    }
}
