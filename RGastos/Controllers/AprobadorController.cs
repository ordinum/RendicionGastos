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
    public class AprobadorController : Controller
    {
        private RGastosContext db = new RGastosContext();

        //
        // GET: /Aprobador/

        public ActionResult Index()
        {
            return View(db.Aprobador.ToList());
        }

        //
        // GET: /Aprobador/Details/5

        public ActionResult Details(int id = 0)
        {
            Aprobador aprobador = db.Aprobador.Find(id);
            if (aprobador == null)
            {
                return HttpNotFound();
            }
            return View(aprobador);
        }

        //
        // GET: /Aprobador/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aprobador/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aprobador aprobador)
        {
            if (ModelState.IsValid)
            {
                db.Aprobador.Add(aprobador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aprobador);
        }

        //
        // GET: /Aprobador/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Aprobador aprobador = db.Aprobador.Find(id);
            if (aprobador == null)
            {
                return HttpNotFound();
            }
            return View(aprobador);
        }

        //
        // POST: /Aprobador/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aprobador aprobador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aprobador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aprobador);
        }

        //
        // GET: /Aprobador/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Aprobador aprobador = db.Aprobador.Find(id);
            if (aprobador == null)
            {
                return HttpNotFound();
            }
            return View(aprobador);
        }

        //
        // POST: /Aprobador/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aprobador aprobador = db.Aprobador.Find(id);
            db.Aprobador.Remove(aprobador);
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