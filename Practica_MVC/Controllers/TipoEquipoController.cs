using Practica_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_MVC.Controllers
{
    public class TipoEquipoController : Controller
    {
        List<TipoEquipo> ListaTipoEquipo = null;
        // GET: TipoEquipo
        public ActionResult Index()
        {

            using (var bd = new MANTENIMIENTOEntities())
            {
                ListaTipoEquipo = (from E in bd.Tipo_Equipo
                                   select new TipoEquipo
                                   {
                                       tipo_equipo = E.tipo_equipo1,
                                       medida = E.medida
                                   }).ToList();


            }           
            return View(ListaTipoEquipo);
        }
    }
}