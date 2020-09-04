using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_MVC.Models;
namespace Practica_MVC.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        List<EquipoCLS> listaEquipo = null;
        public ActionResult Index()
        {
            using (var db = new MANTENIMIENTOEntities())
            {
                /*listaEquipo = (from e in db.Equipo
                               join t in db.Tipo_Equipo on e.id_tipo_equipo equals t.id_tipo_equipo
                               join m in db.Marca on e.id_marca equals m.id_marca
                               select new EquipoCLS
                               {
                                   Equipo = e.equipo1,
                                   Tipo_equipo = t.tipo_equipo1,
                                   Marca = m.marca1
                               }).ToList();*/
                listaEquipo = (from e in db.Tabla_Equipo()
                               select new EquipoCLS
                               {
                                   Equipo = e.equipo,
                                   Tipo_equipo = e.tipo_equipo,
                                   Marca = e.marca
                               }).ToList();
            }

            return View(listaEquipo);
        }
    }
}