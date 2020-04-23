using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoServicio EmpleadoServicio = new EmpleadoServicio();

        // GET: Empleado
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult CrearConRequest()
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = Request["Nombre"];
            empleado.Apellido = Request["Apellido"];

            EmpleadoServicio.Crear(empleado);

            //return View("~/Views/Bienvenido/Index.cshtml");
            //return View("Crear");
            return RedirectToAction("Lista");
        }

        public ActionResult CrearConFormCollection(FormCollection form)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = form["Nombre"];
            empleado.Apellido = form["Apellido"];

            EmpleadoServicio.Crear(empleado);

            return RedirectToAction("Lista");
        }

        public ActionResult Crear(Empleado emp)
        {
            EmpleadoServicio.Crear(emp);

            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            List<Empleado> todos = EmpleadoServicio.ObtenerTodos();
            return View(todos);
        }

        public ActionResult Eliminar(int id)
        {
            EmpleadoServicio.Eliminar(id);
            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Empleado empActual = EmpleadoServicio.ObtenerPorId(id);

            return View(empActual);
        }

        [HttpPost]
        public ActionResult Modificar(Empleado emp)
        {
            EmpleadoServicio.Modificar(emp);

            return RedirectToAction("Lista");
        }
    }
}