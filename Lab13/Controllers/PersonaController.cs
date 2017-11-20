using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Raydy",
                Apellido = "Ponce",
                Direccion = "Santa Elsa B-3",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "raydy_ponce@hotmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Alessandra",
                Apellido = "Rojas",
                Direccion = "Santa Elsa B-4",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "ale@hotmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Yahaira",
                Apellido = "Suarez",
                Direccion = "Santa Elsa B-5",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "yah@hotmail.com"
            });
            return View(personas);
        }

        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,Nombre = "Raydy",Apellido = "Ponce",
                Direccion = "Av Los geranios",
                FechaNac = Convert.ToDateTime("1994-01-23"),
                Email = "ponce@hotmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,Nombre = "Sam",Apellido = "Ponce",
                Direccion = "Av Los geanios",
                FechaNac = Convert.ToDateTime("2001-01-23"),
                Email = "ponoe@hotmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,Nombre = "efe",Apellido = "perez",
                Direccion = "Av Los granios",
                FechaNac = Convert.ToDateTime("1974-01-23"),
                Email = "perez@hotmail.com"
            });

            Persona persona = (from p in personas where p.PersonaID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
    }
}