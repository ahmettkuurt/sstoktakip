﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace sstoktakip.Controllers
{
    public class DashboardController : Controller
    {
       
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v3=c.Blogs.Count().ToString();
            ViewBag.v2=c.Blogs.Where(x=>x.WriterID ==1).Count();
            ViewBag.v1=c.Categories.Count().ToString();
            return View();
        }
        
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
