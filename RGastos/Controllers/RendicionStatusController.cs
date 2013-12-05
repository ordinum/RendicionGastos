using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RGastos.Models;

namespace RGastos.Controllers
{
    public class RendicionStatusController : Controller
    {
        private RGastosContext db = new RGastosContext();

        //
        // GET: /RendicionStatus/

        public ActionResult Index()
        {
            return View(db.RendicionStatus.ToList());
        }

        //
        // GET: /RendicionStatus/Details/5

        public ActionResult Details(int id = 0)
        {
            RendicionStatus rendicionstatus = db.RendicionStatus.Find(id);
            if (rendicionstatus == null)
            {
                return HttpNotFound();
            }
            return View(rendicionstatus);
        }

        //
        // GET: /RendicionStatus/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RendicionStatus/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RendicionStatus rendicionstatus)
        {
            if (ModelState.IsValid)
            {
                db.RendicionStatus.Add(rendicionstatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rendicionstatus);
        }

        //
        // GET: /RendicionStatus/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RendicionStatus rendicionstatus = db.RendicionStatus.Find(id);
            if (rendicionstatus == null)
            {
                return HttpNotFound();
            }
            return View(rendicionstatus);
        }

        //
        // POST: /RendicionStatus/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RendicionStatus rendicionstatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rendicionstatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rendicionstatus);
        }

        //
        // GET: /RendicionStatus/Delete/5

        public ActionResult Delete(int id = 0)
        {
            RendicionStatus rendicionstatus = db.RendicionStatus.Find(id);
            if (rendicionstatus == null)
            {
                return HttpNotFound();
            }
            return View(rendicionstatus);
        }

        //
        // POST: /RendicionStatus/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RendicionStatus rendicionstatus = db.RendicionStatus.Find(id);
            db.RendicionStatus.Remove(rendicionstatus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}