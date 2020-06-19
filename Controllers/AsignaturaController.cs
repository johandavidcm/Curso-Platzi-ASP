using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Platzi.Models;

namespace Platzi.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                new Asignatura{ Nombre="Ciencias Naturales", UniqueId=Guid.NewGuid().ToString() },
                new Asignatura{ Nombre="Español", UniqueId=Guid.NewGuid().ToString() },
                new Asignatura{ Nombre="Ingles", UniqueId=Guid.NewGuid().ToString() },
                new Asignatura{ Nombre="Programación", UniqueId=Guid.NewGuid().ToString() },
                new Asignatura{ Nombre="Perreo", UniqueId=Guid.NewGuid().ToString() }
                
            };
            return View("MultiAsignatura",listaAsignaturas);
        }

        public IActionResult Index(){
            return View(new Asignatura{ Nombre="Perreo", UniqueId=Guid.NewGuid().ToString() });
        }
    }
}