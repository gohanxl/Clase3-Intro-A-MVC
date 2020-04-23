using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class BienvenidoController : Controller
    {
        //localhost/
        //localhost/home/index
        // GET: Bienvenido
        public ActionResult Index()
        {
            return View();
        }

        public string Saludo(string id)
        {
            return $"HOLA {id}!";
        }

        public string SaludoGrupal(string nombre1, string nombre2)
        {
            return $"HOLA {nombre1} y {nombre2}!";
        }
    }
}