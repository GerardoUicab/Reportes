using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reportes.Models;
using Rotativa;

namespace Reportes.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            listaProducto lista = new listaProducto();
            ViewBag.productos = lista.finall();
            return View();
        }
        public ActionResult exportar()
        {
            return new ActionAsPdf("Index")
            {
                FileName=Server.MapPath("~/Content/ListaProductos.pdf")
            };
        }
    }
}