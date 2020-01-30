using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MiprimerproyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Algo = "Soy un mensaje desde el controlado";
            return View();
        }
        public ActionResult Alumno()
        {
            return View();
        }
    }
}