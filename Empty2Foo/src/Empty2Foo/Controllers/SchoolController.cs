﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Empty2Foo.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Empty2Foo.Controllers
{
    public class SchoolController : Controller
    {
        private C__USERS_ASUS_DOCUMENTS_GITLIBRARY_SIMPL__NET_SAMPLE_DATABASE_DATADEMO_MDFContext _dbContext;
        public SchoolController(C__USERS_ASUS_DOCUMENTS_GITLIBRARY_SIMPL__NET_SAMPLE_DATABASE_DATADEMO_MDFContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            School s = new School();
            return View(s);
        }
        [HttpPost]
        public IActionResult Index(School s)
        {
            _dbContext.School.Add(s);
            _dbContext.SaveChanges();
            var schools = _dbContext.School.AsQueryable<School>(); ;
            return View("SchoolList", schools);
        }
    }
}
