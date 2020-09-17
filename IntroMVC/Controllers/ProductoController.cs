using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class ProductoController : Controller
    {
        ProductoServicio ProductoServicio = new ProductoServicio();

        // GET: Producto
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult CrearConRequest()
        {
   
            Producto producto = new Producto();
            producto.Descripcion = Request["Descripcion"];
            producto.Precio = double.Parse(Request["Precio"]);

            ProductoServicio.Crear(producto);

            //return View("~/Views/Bienvenido/Index.cshtml");
            //return View("Crear");
            return RedirectToAction("Lista");
        }

        public ActionResult CrearConFormCollection(FormCollection form)
        {
            Producto producto = new Producto();
            producto.Descripcion = form["Descripcion"];
            producto.Precio = double.Parse(form["Precio"]);

            ProductoServicio.Crear(producto);

            return RedirectToAction("Lista");
        }

        public ActionResult Crear(Producto emp)
        {
            ProductoServicio.Crear(emp);

            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            List<Producto> todos = ProductoServicio.ObtenerTodos();
            return View(todos);
        }

        public ActionResult Eliminar(int id)
        {
            ProductoServicio.Eliminar(id);
            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Producto empActual = ProductoServicio.ObtenerPorId(id);

            return View(empActual);
        }

        [HttpPost]
        public ActionResult Modificar(Producto producto)
        {
            ProductoServicio.Modificar(producto);

            return RedirectToAction("Lista");
        }
    }
}