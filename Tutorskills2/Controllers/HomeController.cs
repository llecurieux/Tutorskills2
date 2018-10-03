﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorskills2.Models;

namespace Tutorskills2.Controllers
{
    public class HomeController : Controller
    {

        public TutorskillsDb _db = new TutorskillsDb();

        public ActionResult Index()
        {
            var model = _db.Posts.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);

        }
    }
}