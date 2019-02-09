using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicatieMedia.Models;

namespace AplicatieMedia.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Numere());
        }
        [HttpPost]
        public ActionResult Index(Numere Numere)
        {
            return View(Numere);
        }
        [HttpPost]
        public ActionResult CreateNumere(Numere Numere)
        {
            
            double m = (double)((Numere.Numar1 + Numere.Numar2 + Numere.Numar3)) / 3;
            
            string rez = "(" + Numere.Numar1.ToString()+ " + "+ Numere.Numar3.ToString() + " + " + Numere.Numar3.ToString() + ")" + "/" + "3" + "=" + m.ToString("F3");
            ViewBag.media = rez;
            return View();
        }
        
       

    }
}