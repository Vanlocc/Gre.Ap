using Gre.Ap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gre.Ap.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee
        public ActionResult Index()
        {
            var listTrainee = new TraineeDbContext().Trainees.ToList();
            return View(listTrainee);
        }

        // GET: Trainee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trainee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainee/Create
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

        // GET: Trainee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trainee/Edit/5
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

        // GET: Trainee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trainee/Delete/5
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
