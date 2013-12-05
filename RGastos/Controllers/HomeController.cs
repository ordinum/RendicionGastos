using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RGastos.ViewModels;
using RGastos.Models;


namespace RGastos.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private RGastosContext db = new RGastosContext();

        public ActionResult Index()
        {
            var rendiciones = new RendicionIndexData();

            rendiciones.RendicionesPendientes = db.Rendicion.Where(p => p.RendicionStatusID == 1).ToList(); //1 = Pending
            rendiciones.RendicionesAprobadas = db.Rendicion.Where(a => a.RendicionStatusID == 2).ToList(); // 2 = Approved
            rendiciones.RendicionesRechazadas = db.Rendicion.Where(r => r.RendicionStatusID == 3).ToList(); // 3 = Rejected
            
            return View(rendiciones);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
