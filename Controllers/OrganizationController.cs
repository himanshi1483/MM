﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mahamesh.Controllers
{
    public class OrganizationController : Controller
    {
        // GET: Organization
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ministers()
        {
            return View();
        }

        public ActionResult KeyOfficials()
        {
            return View();
        }

        public ActionResult ObjectOfOrganization()
        {
            return View();
        }
        public ActionResult VariousCommittees()
        {
            return View();
        }

        public ActionResult OfficeBearers()
        {
            return View();
        }

        public ActionResult BoardOfDirectors()
        {
            return View();
        }

        // GET: Organization/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Organization/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Organization/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Organization/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Organization/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Organization/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Organization/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
