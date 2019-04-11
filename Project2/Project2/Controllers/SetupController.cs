using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class SetupController : Controller
    {
        private Project db = new Project();

        // GET: Setup
        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        // GET: Setup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameViewModel gameViewModel = db.Games.Find(id);
            if (gameViewModel == null)
            {
                return HttpNotFound();
            }
            return View(gameViewModel);
        }

        // GET: Setup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Setup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,owner,category,numPlayers,name")] GameViewModel gameViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(gameViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameViewModel);
        }

        // GET: Setup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameViewModel gameViewModel = db.Games.Find(id);
            if (gameViewModel == null)
            {
                return HttpNotFound();
            }
            return View(gameViewModel);
        }

        // POST: Setup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,owner,category,numPlayers,name")] GameViewModel gameViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameViewModel);
        }

        // GET: Setup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameViewModel gameViewModel = db.Games.Find(id);
            if (gameViewModel == null)
            {
                return HttpNotFound();
            }
            return View(gameViewModel);
        }

        // POST: Setup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameViewModel gameViewModel = db.Games.Find(id);
            db.Games.Remove(gameViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        // GET: Setup/Create
        public ActionResult About()
        {
            return View();
        }
    }
}
