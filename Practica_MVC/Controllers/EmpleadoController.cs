using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_MVC.Models;
namespace Practica_MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        List<EmpleadoCLS> listaEmpleado = null;
        // GET: Empleado
        public ActionResult Index()
        {
            using (var database = new MANTENIMIENTOEntities())
            {
                
                listaEmpleado = (from E in database.tabla_Empleado()
                                 select new EmpleadoCLS
                                 {
                                     id_empleado = E.id_empleado,
                                     salario_por_hora = (float)E.salario_por_hora,
                                     nombre = E.nombre
                                 }).ToList();
            }
            return View(listaEmpleado);
        }
    }
}