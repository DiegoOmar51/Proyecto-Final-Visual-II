using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebAApp.Controllers
{
    public class SalarioController : Controller
    {  // DbContext
        private readonly AcademiaDB db;

        public SalarioController(AcademiaDB db)
        {
            this.db = db;
        }

        // Listado de matrículas
        public IActionResult Index()
        {
            var listaMatriculas = db.salarios
                .Include(matricula => matricula.decterceros)
                .Include(matricula => matricula.Personal)
                .Include(matricula => matricula.roles)
                ;

            return View(listaMatriculas);

            
        }
        public IActionResult Index1()
        {
            IEnumerable<Personal> listaEmpleados = db.personales;
            return View(listaEmpleados);


        }

        // Pantalla para la validación de la matrícula
        public IActionResult Validar(int id)
        {
            var matricula = db.salarios
                   .Include(matr => matr.Personal)
                   .Include(matr => matr.salarioDetalles)
                       .ThenInclude(det => det.Empresa)
                           .ThenInclude(cur => cur.roles
                           )
                                       .Include(matricula => matricula.salarioDetalles)
                    .ThenInclude(matricula_dets => matricula_dets.Roles)
                   .Single(salario => salario.SalarioId == id); 
            // Preparar la clase para el cálculo de las calificaciones
            var configuracion = db.configuracion.Single();
            CalSueldo calcCalificaciones = new CalSueldo(configuracion);

            ViewBag.CalcCalificaciones = calcCalificaciones;
           

            return View(matricula);
        }
        public IActionResult Edit(int id)
        {
            Salario empleado = db.salarios.Find(id);
                return View(empleado);
        }
        [HttpPost]
        public IActionResult Edit(Personal empleado)
        {
            //Grabar Empleado
            //db.personales.Update(empleado);
            //db.SaveChanges();

            TempData["mensaje"] = $"El empleado {empleado.Nombre} ha sido liquidado exitosamente";

            return RedirectToAction("Index1");
        }
    }
}
