using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_MVC.Models;

namespace Practica_MVC.Controllers
{
    public class Tipo_EquipoController : Controller
    {
        List<Tipo_EquipoCLS> ListaTipoEquipo = null;
        // GET: TipoEquipo
        public ActionResult Index()
        {

            using (var bd = new MANTENIMIENTOEntities())
            {
                ListaTipoEquipo = (from E in bd.tabla_Tipo_Equipo()
                                   select new Tipo_EquipoCLS
                                   {
                                       tipo_equipo = E.tipo_equipo,
                                       medida = E.medida
                                   }).ToList();


            }
            return View(ListaTipoEquipo);
        }
    }
}