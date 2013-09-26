using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RGastos.Models;
using RGastos.DAL;

namespace RGastos.Controllers
{
    public class RendicionController : Controller
    {
        //Clases de Contexto...
        private RGastosContext db = new RGastosContext();
        private CVisitsDataContext cv = new CVisitsDataContext();


        //Implementa repositorio VISITAS...
        private IVisitsRepository visitsRepository;

        public RendicionController()
        {
            this.visitsRepository = new VisitsRepository(new CVisitsDataContext());
        }      

        public RendicionController(IVisitsRepository visitsRepository){
            this.visitsRepository=visitsRepository;
        }


        
        //
        // GET: /Rendicion/

        public ActionResult Index()
        {
            var rendicion = db.Rendicion.Include(r => r.UserProfile);
            return View(rendicion.ToList());
        }

        //
        // GET: /Rendicion/Details/5

        public ActionResult Details(int id = 0)
        {
            Rendicion rendicion = db.Rendicion.Find(id);
            if (rendicion == null)
            {
                return HttpNotFound();
            }
            return View(rendicion);
        }

     
        public JsonResult ObtenerVisita(int visitId)
        {
            //var resultado = visitsRepository.GetVisitByID(visitId);                                   

            var resultado = from v in cv.Visita
                            where v.VisitaID == visitId
                            select new { v.FechaIngreso, v.FechaPlanificada, v.Descripcion };

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public PartialViewResult ListadoVisitas(int visitId)
        {

            var resultado = visitsRepository.GetVisitByID(visitId);
            ViewBag.FechaIngreso = resultado.FechaIngreso.ToShortDateString();
            ViewBag.FechaPlanificada = resultado.FechaPlanificada.ToShortDateString();
            ViewBag.Descripcion = resultado.Descripcion;
            
            //Name of our PartialView is Restaurant
            return PartialView("_ListadoVisitas");
        }



        //
        // GET: /Rendicion/Create

        public ActionResult Create()
        {
            ViewBag.VisitaID = new SelectList(visitsRepository.GetVisits(), "VisitaID", "Descripcion");
            ViewBag.UserId = new SelectList(db.UserProfiles, "UserId", "UserName");
            ViewBag.TodasVisitas = visitsRepository.GetVisits();
            return View();
        }

        //
        // POST: /Rendicion/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rendicion rendicion)
        {
            if (ModelState.IsValid)
            {
                db.Rendicion.Add(rendicion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VisitaID = new SelectList(visitsRepository.GetVisits(), "VisitaID", "Descripcion");
            ViewBag.UserId = new SelectList(db.UserProfiles, "UserId", "UserName", rendicion.UserId);
            ViewBag.TodasVisitas = visitsRepository.GetVisits();

            return View(rendicion);
        }

        //
        // GET: /Rendicion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Rendicion rendicion = db.Rendicion.Find(id);
            if (rendicion == null)
            {
                return HttpNotFound();
            }
            ViewBag.VisitaID = new SelectList(cv.Visita, "VisitaID", "Descripcion", rendicion.VisitaID);
            ViewBag.UserId = new SelectList(db.UserProfiles, "UserId", "UserName", rendicion.UserId);
            return View(rendicion);
        }

        //
        // POST: /Rendicion/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rendicion rendicion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rendicion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VisitaID = new SelectList(cv.Visita, "VisitaID", "Descripcion", rendicion.VisitaID);
            ViewBag.UserId = new SelectList(db.UserProfiles, "UserId", "UserName", rendicion.UserId);
            return View(rendicion);
        }

        //
        // GET: /Rendicion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Rendicion rendicion = db.Rendicion.Find(id);
            if (rendicion == null)
            {
                return HttpNotFound();
            }
            return View(rendicion);
        }

        //
        // POST: /Rendicion/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rendicion rendicion = db.Rendicion.Find(id);
            db.Rendicion.Remove(rendicion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            visitsRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}