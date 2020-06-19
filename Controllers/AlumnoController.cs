using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Platzi.Models;
using System.Linq;

namespace Platzi.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult MultiAlumno()
        {
            return View("MultiAlumno",GenerarAlumnosAlAzar());
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}",
                                   UniqueId = Guid.NewGuid().ToString()
                                };

            return listaAlumnos.ToList();
        }

        public IActionResult Index(){
            return View(new Alumno{ UniqueId = Guid.NewGuid().ToString(), Nombre="Johan David" });
        }
    }
}