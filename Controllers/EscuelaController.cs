using System;
using Microsoft.AspNetCore.Mvc;
using Platzi.Models;

namespace Platzi.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Pascual";
            escuela.Ciudad = "Medellín";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Direccion = "Calle 98c # 80 - 18";
            ViewBag.CosaDinamica = "Iron Man";
            return View(escuela);
        }
    }
}