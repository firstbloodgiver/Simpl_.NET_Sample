using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Empty2Foo.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Empty2Foo.Controllers
{
    public class HotsellController : Controller
    {
        private readonly DBScoolContext db;

        public HotsellController(DBScoolContext schooldb)
        {
            db = schooldb;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            School s = new School();
            ViewBag.news = new[] { "新年送花留言", "情人节的由来", "古今鲜花浪漫故事", "如何让鲜花保存更长时间" };
            ViewBag.imgs = new[] { "/img/recom.jpg", "/img/special.jpg"};
            var schools = db.School.Where<School>(m => m.ObjId > 10).Take<School>(6);
            return View(schools);
        }
    }
}
