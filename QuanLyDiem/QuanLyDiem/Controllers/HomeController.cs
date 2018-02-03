﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Controllers
{
    public class HomeController : Controller
    {
        public HighSchool db = new HighSchool();
        // GET: Home
        public ActionResult Index()
        {
            List<DanhMuc> categories = db.DanhMucs.ToList();
            return View(categories);
        }
    }
}