using abril12021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace abril12021.Controllers
{
    public class ProductoController : Controller
    {
        // localhost:55555/Producto/
        // localhost:55555/Producto/Index
        public ActionResult Index()
        {
            var cocacola=new Producto("cod1","cocacola",2000);
            var fanta=new Producto("cod2","fanta",3000);
            var sprite=new Producto("cod3","sprite",5000);

            // Viewbag tiene una propiedad dinamica.
            ViewBag.cocacola=cocacola;
            ViewBag.fanta=fanta;
            // ViewData (diccionario)
            ViewData["fanta"]=fanta;           
            return View(sprite);
        }
        public ActionResult Listar()
        {
            var cocacola=new Producto("cod1","cocacola",2000);
            var fanta=new Producto("cod2","fanta",3000);
            var sprite=new Producto("cod3","sprite",5000);
            List<Producto> listado=new List<Producto>();
            listado.Add(cocacola);
            listado.Add(fanta);
            listado.Add(sprite);

            ViewBag.listado=listado;
            return View("ListarV2",listado);
        }
        public ActionResult ListarBootstrap()
        {
            var cocacola=new Producto("cod1","cocacola",2000);
            var fanta=new Producto("cod2","fanta",3000);
            var sprite=new Producto("cod3","sprite",5000);
            List<Producto> listado=new List<Producto>();
            listado.Add(cocacola);
            listado.Add(fanta);
            listado.Add(sprite);

            return View(listado);
        }

        [HttpGet]
        public ActionResult Formulario()
        {
            // formulario inicial
            var modelo=new Producto();

            return View(modelo);
        }
        [HttpPost]
        public ActionResult Formulario(Producto modelo)
        {
            // aqui hacemos la operacion
            return View(modelo);
        }


    }
}