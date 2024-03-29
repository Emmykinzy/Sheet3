﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Sheet3.Models;

namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DBManager db = new DBManager();
            var records = db.GetAllActive();

            return View(records);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact c)
        {
            DBManager db = new DBManager();
            db.Add(c);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            DBManager db = new DBManager();
            var currRecord = db.Details(id);

            return View(currRecord);
        }

        public ActionResult Delete(int id)
        {
            DBManager db = new DBManager();
            db.Delete(id);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            DBManager db = new DBManager();
            var record = db.Details(id);

            return View(record);
        }

        [HttpPost]
        public ActionResult Edit(Contact c)
        {
            DBManager db = new DBManager();
            db.Update(c);

            return RedirectToAction("Index");
        }
    }
}