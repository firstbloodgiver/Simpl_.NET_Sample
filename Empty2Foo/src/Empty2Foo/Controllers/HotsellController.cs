using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Empty2Foo.Controllers
{
    public class HotsellController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.news = new[] { "新年送花留言", "情人节的由来", "古今鲜花浪漫故事", "如何让鲜花保存更长时间" };
            return View();
        }
    }
}
